namespace AmigoSecreto
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
            this.chkEmbaralhar = new System.Windows.Forms.CheckBox();
            this.chkExibir = new System.Windows.Forms.CheckBox();
            this.cmdReiniciar = new System.Windows.Forms.Button();
            this.cmdSortear = new System.Windows.Forms.Button();
            this.lstParticipantes = new System.Windows.Forms.ListBox();
            this.cmdCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEmbaralhar
            // 
            this.chkEmbaralhar.AutoSize = true;
            this.chkEmbaralhar.Location = new System.Drawing.Point(188, 167);
            this.chkEmbaralhar.Name = "chkEmbaralhar";
            this.chkEmbaralhar.Size = new System.Drawing.Size(79, 17);
            this.chkEmbaralhar.TabIndex = 10;
            this.chkEmbaralhar.Text = "Embaralhar";
            this.chkEmbaralhar.UseVisualStyleBackColor = true;
            // 
            // chkExibir
            // 
            this.chkExibir.AutoSize = true;
            this.chkExibir.Location = new System.Drawing.Point(188, 144);
            this.chkExibir.Name = "chkExibir";
            this.chkExibir.Size = new System.Drawing.Size(101, 17);
            this.chkExibir.TabIndex = 8;
            this.chkExibir.Text = "Exibir ao sortear";
            this.chkExibir.UseVisualStyleBackColor = true;
            // 
            // cmdReiniciar
            // 
            this.cmdReiniciar.Enabled = false;
            this.cmdReiniciar.Location = new System.Drawing.Point(188, 94);
            this.cmdReiniciar.Name = "cmdReiniciar";
            this.cmdReiniciar.Size = new System.Drawing.Size(101, 23);
            this.cmdReiniciar.TabIndex = 9;
            this.cmdReiniciar.Text = "Reiniciar";
            this.cmdReiniciar.UseVisualStyleBackColor = true;
            this.cmdReiniciar.Click += new System.EventHandler(this.cmdReiniciar_Click);
            // 
            // cmdSortear
            // 
            this.cmdSortear.Enabled = false;
            this.cmdSortear.Location = new System.Drawing.Point(188, 65);
            this.cmdSortear.Name = "cmdSortear";
            this.cmdSortear.Size = new System.Drawing.Size(101, 23);
            this.cmdSortear.TabIndex = 7;
            this.cmdSortear.Text = "Sortear";
            this.cmdSortear.UseVisualStyleBackColor = true;
            this.cmdSortear.Click += new System.EventHandler(this.cmdSortear_Click);
            // 
            // lstParticipantes
            // 
            this.lstParticipantes.FormattingEnabled = true;
            this.lstParticipantes.Location = new System.Drawing.Point(12, 12);
            this.lstParticipantes.Name = "lstParticipantes";
            this.lstParticipantes.Size = new System.Drawing.Size(161, 225);
            this.lstParticipantes.TabIndex = 6;
            // 
            // cmdCarregar
            // 
            this.cmdCarregar.Location = new System.Drawing.Point(188, 12);
            this.cmdCarregar.Name = "cmdCarregar";
            this.cmdCarregar.Size = new System.Drawing.Size(101, 23);
            this.cmdCarregar.TabIndex = 6;
            this.cmdCarregar.Text = "Carregar lista";
            this.cmdCarregar.UseVisualStyleBackColor = true;
            this.cmdCarregar.Click += new System.EventHandler(this.cmdCarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 252);
            this.Controls.Add(this.cmdCarregar);
            this.Controls.Add(this.lstParticipantes);
            this.Controls.Add(this.cmdSortear);
            this.Controls.Add(this.cmdReiniciar);
            this.Controls.Add(this.chkExibir);
            this.Controls.Add(this.chkEmbaralhar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Amigo Secreto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkEmbaralhar;
        private System.Windows.Forms.CheckBox chkExibir;
        private System.Windows.Forms.Button cmdReiniciar;
        private System.Windows.Forms.Button cmdSortear;
        private System.Windows.Forms.ListBox lstParticipantes;
        private System.Windows.Forms.Button cmdCarregar;
    }
}

