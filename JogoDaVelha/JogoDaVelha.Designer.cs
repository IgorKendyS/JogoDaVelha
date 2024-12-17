namespace JogoDaVelha
{
    partial class JogoDaVelha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogo da Velha";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(409, 89);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(138, 124);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(247, 89);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(138, 124);
            this.btn2.TabIndex = 9;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Onyx", 8.25F);
            this.btn1.Location = new System.Drawing.Point(77, 89);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(138, 124);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(247, 230);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(138, 124);
            this.btn5.TabIndex = 2;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(409, 230);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(138, 124);
            this.btn6.TabIndex = 4;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(77, 380);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(138, 127);
            this.btn7.TabIndex = 5;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(77, 230);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(138, 124);
            this.btn4.TabIndex = 6;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(247, 380);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(138, 124);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(409, 380);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(138, 124);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // JogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 538);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "JogoDaVelha";
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.JogoDaVelha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
    }
}

