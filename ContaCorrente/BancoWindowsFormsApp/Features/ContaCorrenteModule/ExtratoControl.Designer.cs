namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    partial class ExtratoControl
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
            this.listBoxExtrato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxExtrato
            // 
            this.listBoxExtrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExtrato.FormattingEnabled = true;
            this.listBoxExtrato.Location = new System.Drawing.Point(0, 0);
            this.listBoxExtrato.Name = "listBoxExtrato";
            this.listBoxExtrato.Size = new System.Drawing.Size(376, 237);
            this.listBoxExtrato.TabIndex = 0;
            // 
            // ExtratoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxExtrato);
            this.Name = "ExtratoControl";
            this.Size = new System.Drawing.Size(376, 237);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExtrato;
    }
}
