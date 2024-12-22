namespace JogoDaVelha
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNivelJogo = new System.Windows.Forms.GroupBox();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNivelJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(7, 9);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(182, 25);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(12, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // lblNivelJogo
            // 
            this.lblNivelJogo.Controls.Add(this.rdbHard);
            this.lblNivelJogo.Controls.Add(this.rdbEasy);
            this.lblNivelJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelJogo.Location = new System.Drawing.Point(12, 83);
            this.lblNivelJogo.Name = "lblNivelJogo";
            this.lblNivelJogo.Size = new System.Drawing.Size(241, 76);
            this.lblNivelJogo.TabIndex = 2;
            this.lblNivelJogo.TabStop = false;
            this.lblNivelJogo.Text = "Nível do Jogo";
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHard.Location = new System.Drawing.Point(122, 28);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(98, 35);
            this.rdbHard.TabIndex = 1;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Difícil";
            this.rdbHard.UseVisualStyleBackColor = true;
            this.rdbHard.Click += new System.EventHandler(this.rdbHard_Click);
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Checked = true;
            this.rdbEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEasy.Location = new System.Drawing.Point(19, 28);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(90, 35);
            this.rdbEasy.TabIndex = 0;
            this.rdbEasy.TabStop = true;
            this.rdbEasy.Text = "Fácil";
            this.rdbEasy.UseVisualStyleBackColor = true;
            this.rdbEasy.CheckedChanged += new System.EventHandler(this.rdbEasy_CheckedChanged);
            this.rdbEasy.Click += new System.EventHandler(this.rdbEasy_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(241, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Iniciar Jogo";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 210);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNivelJogo);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblNomeJogador);
            this.Name = "User";
            this.Text = "User";
            this.lblNivelJogo.ResumeLayout(false);
            this.lblNivelJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox lblNivelJogo;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.Button btnStart;
    }
}