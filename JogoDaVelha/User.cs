using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class User : Form
    {
        private JogoDaVelha jogoDaVelha;
        public User(JogoDaVelha jogo)
        {
            InitializeComponent();
            jogoDaVelha = jogo;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Por favor, insira um nome!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            string level = rdbEasy.Checked ? rdbEasy.Text : rdbHard.Text;

            jogoDaVelha.AtualizarDados(txtUsername.Text, level);

            jogoDaVelha.Show();
            this.Hide();
        }

        private void rdbEasy_CheckedChanged(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(255, 200, 100);
        }

        private void rdbHard_Click(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(200, 20, 20);
        }

    }
}
