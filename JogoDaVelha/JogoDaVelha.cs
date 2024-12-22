using System;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class JogoDaVelha : Form
    {
        private bool turnoX = true;
        private int jogadas = 0;

        public JogoDaVelha()
        {
            InitializeComponent();
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

            if (VerificarVencedor())
            {
                MessageBox.Show($"Jogador {(turnoX ? "X" : "O")} venceu!");
                btnRestart.Visible = true;
                return;
            }

            if (jogadas == 9)
            {
                MessageBox.Show("Empate!");
                btnRestart.Visible = true;
                return;
            }

            turnoX = !turnoX;
        }

        private bool VerificarVencedor()
        {
            return (
                (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "") ||
                (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "") ||
                (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "") ||

                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "") ||
                (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "") ||
                (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "") ||

                (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "") ||
                (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            );
        }

        private void ReiniciarJogo()
        {
            btnRestart.Visible = false;

            btn1.Text = "";
            btn1.Enabled = true;
            btn2.Text = "";
            btn2.Enabled = true;
            btn3.Text = "";
            btn3.Enabled = true;
            btn4.Text = "";
            btn4.Enabled = true;
            btn5.Text = "";
            btn5.Enabled = true;
            btn6.Text = "";
            btn6.Enabled = true;
            btn7.Text = "";
            btn7.Enabled = true;
            btn8.Text = "";
            btn8.Enabled = true;
            btn9.Text = "";
            btn9.Enabled = true;

            turnoX = true;
            jogadas = 0;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }
    }
}
