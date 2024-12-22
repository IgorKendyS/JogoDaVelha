using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Ranking : Form
    {
        private const string RankingFile = "ranking.bin";

        public Ranking()
        {
            InitializeComponent();
            ExibirRanking();
        }

        private void ExibirRanking()
        {
            var ranking = CarregarRanking();

            // Ordenar ranking por pontuação decrescente
            var rankingOrdenado = ranking
                .OrderByDescending(r => r.Pontuacao)
                .ToList();

            dgvRanking.DataSource = rankingOrdenado;

            dgvRanking.Columns["Nome"].HeaderText = "Nome";
            dgvRanking.Columns["JogosFacil"].HeaderText = "Jogos (Fácil)";
            dgvRanking.Columns["VitoriasFacil"].HeaderText = "Vitórias (Fácil)";
            dgvRanking.Columns["JogosDificil"].HeaderText = "Jogos (Difícil)";
            dgvRanking.Columns["VitoriasDificil"].HeaderText = "Vitórias (Difícil)";
            dgvRanking.Columns["Pontuacao"].HeaderText = "Pontuação";
        }

        private List<JogoDaVelha.RankingEntry> CarregarRanking()
        {
            if (File.Exists(RankingFile))
            {
                using (var stream = new FileStream(RankingFile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<JogoDaVelha.RankingEntry>)formatter.Deserialize(stream);
                }
            }
            return new List<JogoDaVelha.RankingEntry>(); // Retorna uma lista vazia se o arquivo não existir
        }
    }
}