using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class JogoDaVelha : Form
    {
        [Serializable]
        public class RankingEntry
        {
            public string Nome { get; set; }
            public int JogosFacil { get; set; }
            public int VitoriasFacil { get; set; }
            public int JogosDificil { get; set; }
            public int VitoriasDificil { get; set; }
            public int Pontuacao => (VitoriasFacil * 1) + (VitoriasDificil * 2);
        }

        private List<RankingEntry> ranking = new List<RankingEntry>();
        private const string RankingFile = "ranking.bin";

        private User userConfig;
        private bool turnoX = true;
        private int jogadas = 0;
        private string user;
        private string lvl;

        public JogoDaVelha(string username, string level)
        {
            InitializeComponent();
            user = username;
            lvl = level;
            lblUsername.Text = $"Olá {user}";

            CarregarRanking();
            ReiniciarJogo();
        }

        public void AtualizarDados(string username, string level)
        {
            user = username;
            lvl = level;
            lblUsername.Text = $"Olá {user}";
            ReiniciarJogo();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
            {
                MessageBox.Show("Essa célula já foi escolhida!");
                return;
            }

            btn.Text = turnoX ? "X" : "O";
            btn.Enabled = false;
            jogadas++;

            if (ProcessarJogada(btn.Text))
                return;

            turnoX = !turnoX;

            if (!turnoX)
            {
                JogadaMaquina();
                if (ProcessarJogada("O"))
                    return;
                turnoX = true; 
            }
        }

        private bool ProcessarJogada(string jogador)
        {
            if (VerificarVencedor(jogador))
            {
                MessageBox.Show($"Jogador {jogador} venceu!");
                AtualizarRanking(jogador == "X" ? true : false);
                btnRestart.Visible = true;
                return true;
            }

            if (jogadas == 9)
            {
                MessageBox.Show("Empate!");
                AtualizarRanking(false);
                btnRestart.Visible = true;
                return true;
            }

            return false;
        }

        private void AtualizarRanking(bool vitoria)
        {
            var entry = ranking.FirstOrDefault(r => r.Nome == user);
            if (entry == null)
            {
                entry = new RankingEntry { Nome = user };
                ranking.Add(entry);
            }

            if (lvl == "Fácil")
            {
                entry.JogosFacil++;
                if (vitoria) entry.VitoriasFacil++;
            }
            else if (lvl == "Difícil")
            {
                entry.JogosDificil++;
                if (vitoria) entry.VitoriasDificil++;
            }

            SalvarRanking();
        }

        private void SalvarRanking()
        {
            using (var stream = new FileStream(RankingFile, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, ranking);
            }
        }

        private void JogadaMaquina()
        {
            if (lvl == "Fácil")
                JogadaFacil();
            else if (lvl == "Difícil")
                JogadaDificil();
        }

        private void CarregarRanking()
        {
            if (File.Exists(RankingFile))
            {
                using (var stream = new FileStream(RankingFile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    ranking = (List<RankingEntry>)formatter.Deserialize(stream);
                }
            }
        }

        private void JogadaFacil()
        {
            var botoesDisponiveis = ObterBotoesDisponiveis();
            if (botoesDisponiveis.Count > 0)
            {
                Random rand = new Random();
                var botaoEscolhido = botoesDisponiveis[rand.Next(botoesDisponiveis.Count)];
                RealizarJogada(botaoEscolhido, "O");
            }
        }

        private void JogadaDificil()
        {
            Button[] board = ObterTabuleiro();

            int bestScore = int.MinValue;
            Button bestMove = null;

            foreach (var botao in board.Where(b => b.Text == ""))
            {
                botao.Text = "O";
                jogadas++;
                int score = Minimax(board, false, int.MinValue, int.MaxValue);
                botao.Text = "";
                jogadas--;

                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = botao;
                }
            }

            if (bestMove != null)
                RealizarJogada(bestMove, "O");
        }

        private int Minimax(Button[] board, bool isMaximizing, int alpha, int beta)
        {
            if (VerificarVencedor("O")) return 1;
            if (VerificarVencedor("X")) return -1;
            if (jogadas == 9) return 0;

            int bestScore = isMaximizing ? int.MinValue : int.MaxValue;

            foreach (var botao in board.Where(b => b.Text == ""))
            {
                botao.Text = isMaximizing ? "O" : "X";
                jogadas++;
                int score = Minimax(board, !isMaximizing, alpha, beta);
                botao.Text = "";
                jogadas--;

                if (isMaximizing)
                {
                    bestScore = Math.Max(score, bestScore);
                    alpha = Math.Max(alpha, score);
                }
                else
                {
                    bestScore = Math.Min(score, bestScore);
                    beta = Math.Min(beta, score);
                }

                if (beta <= alpha) break;
            }

            return bestScore;
        }

        private bool VerificarVencedor(string jogador)
        {
            return (
                (btn1.Text == jogador && btn2.Text == jogador && btn3.Text == jogador) ||
                (btn4.Text == jogador && btn5.Text == jogador && btn6.Text == jogador) ||
                (btn7.Text == jogador && btn8.Text == jogador && btn9.Text == jogador) ||
                (btn1.Text == jogador && btn4.Text == jogador && btn7.Text == jogador) ||
                (btn2.Text == jogador && btn5.Text == jogador && btn8.Text == jogador) ||
                (btn3.Text == jogador && btn6.Text == jogador && btn9.Text == jogador) ||
                (btn1.Text == jogador && btn5.Text == jogador && btn9.Text == jogador) ||
                (btn3.Text == jogador && btn5.Text == jogador && btn7.Text == jogador)
            );
        }

        private void ReiniciarJogo()
        {
            btnRestart.Visible = false;
            foreach (var btn in Controls.OfType<Button>().Where(b => b.Name != "btnRestart"))
            {
                btn.Text = "";
                btn.Enabled = true;
            }

            turnoX = true;
            jogadas = 0;
        }

        private void RealizarJogada(Button btn, string jogador)
        {
            btn.Text = jogador;
            btn.Enabled = false;
            jogadas++;
        }

        private Button[] ObterTabuleiro() =>
            Controls.OfType<Button>().Where(b => b.Name != "btnRestart").ToArray();

        private System.Collections.Generic.List<Button> ObterBotoesDisponiveis() =>
            Controls.OfType<Button>().Where(b => b.Text == "" && b.Name != "btnRestart").ToList();

        private void btnRestart_Click(object sender, EventArgs e) => ReiniciarJogo();

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userConfig == null || userConfig.IsDisposed)
                userConfig = new User(this);
            userConfig.Show();
            userConfig.BringToFront();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Ranking)
                {
                    form.Focus();
                    return;
                }
            }

            var rankingForm = new Ranking();
            rankingForm.Show();
        }
    }
}
