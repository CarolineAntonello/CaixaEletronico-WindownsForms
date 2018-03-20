namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    partial class ContaCorrenteControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listContasCorrentes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContasCorrentes
            // 
            this.listContasCorrentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContasCorrentes.FormattingEnabled = true;
            this.listContasCorrentes.Location = new System.Drawing.Point(0, 0);
            this.listContasCorrentes.Name = "listContasCorrentes";
            this.listContasCorrentes.Size = new System.Drawing.Size(578, 344);
            this.listContasCorrentes.TabIndex = 0;
            // 
            // CadastroContaCorrenteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listContasCorrentes);
            this.Name = "CadastroContaCorrenteControl";
            this.Size = new System.Drawing.Size(578, 344);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listContasCorrentes;
    }
}
