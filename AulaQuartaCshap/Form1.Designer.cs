
namespace AulaQuartaCshap
{
    partial class Form1
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btExe = new System.Windows.Forms.Button();
            this.btlimpa = new System.Windows.Forms.Button();
            this.btsaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBox.CausesValidation = false;
            this.txtBox.Location = new System.Drawing.Point(36, 25);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(137, 20);
            this.txtBox.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(51, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(85, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Insira Seu Nome";
            // 
            // btExe
            // 
            this.btExe.BackColor = System.Drawing.Color.Yellow;
            this.btExe.Location = new System.Drawing.Point(36, 51);
            this.btExe.Name = "btExe";
            this.btExe.Size = new System.Drawing.Size(136, 23);
            this.btExe.TabIndex = 2;
            this.btExe.Text = "Dizer Olá...";
            this.btExe.UseVisualStyleBackColor = false;
            this.btExe.Click += new System.EventHandler(this.btExe_Click);
            // 
            // btlimpa
            // 
            this.btlimpa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlimpa.ForeColor = System.Drawing.Color.Black;
            this.btlimpa.Location = new System.Drawing.Point(36, 81);
            this.btlimpa.Name = "btlimpa";
            this.btlimpa.Size = new System.Drawing.Size(136, 23);
            this.btlimpa.TabIndex = 3;
            this.btlimpa.Text = "Limpar";
            this.btlimpa.UseVisualStyleBackColor = false;
            this.btlimpa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btsaida
            // 
            this.btsaida.AutoSize = true;
            this.btsaida.Location = new System.Drawing.Point(33, 107);
            this.btsaida.Name = "btsaida";
            this.btsaida.Size = new System.Drawing.Size(10, 13);
            this.btsaida.TabIndex = 5;
            this.btsaida.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(287, 213);
            this.Controls.Add(this.btsaida);
            this.Controls.Add(this.btlimpa);
            this.Controls.Add(this.btExe);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Hello Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btExe;
        private System.Windows.Forms.Button btlimpa;
        private System.Windows.Forms.Label btsaida;
    }
}

