namespace BancoWindowsFormsApp
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContaCorrenteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contaCorrenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contaCorrenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contaCorrenteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.movimentacaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoOperacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrarConta = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnRealizarSaque = new System.Windows.Forms.ToolStripButton();
            this.btnRealizarDeposito = new System.Windows.Forms.ToolStripButton();
            this.btnTransferencia = new System.Windows.Forms.ToolStripButton();
            this.btnExtrato = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOperacaoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContaCorrenteMenuItem,
            this.clienteMenuItem,
            this.sairMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // ContaCorrenteMenuItem
            // 
            this.ContaCorrenteMenuItem.Name = "ContaCorrenteMenuItem";
            this.ContaCorrenteMenuItem.Size = new System.Drawing.Size(182, 24);
            this.ContaCorrenteMenuItem.Text = "Conta Corrente";
            this.ContaCorrenteMenuItem.Click += new System.EventHandler(this.ContaCorrenteMenuItem_Click);
            // 
            // clienteMenuItem
            // 
            this.clienteMenuItem.Name = "clienteMenuItem";
            this.clienteMenuItem.Size = new System.Drawing.Size(182, 24);
            this.clienteMenuItem.Text = "Cliente";
            this.clienteMenuItem.Click += new System.EventHandler(this.clienteMenuItem_Click);
            // 
            // sairMenuItem
            // 
            this.sairMenuItem.Name = "sairMenuItem";
            this.sairMenuItem.Size = new System.Drawing.Size(182, 24);
            this.sairMenuItem.Text = "Sair";
            this.sairMenuItem.Click += new System.EventHandler(this.sairMenuItem_Click);
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataSource = typeof(CaixaEletronico.Movimentacao);
            // 
            // contaCorrenteBindingSource
            // 
            this.contaCorrenteBindingSource.DataSource = typeof(CaixaEletronico.ContaCorrente);
            // 
            // contaCorrenteBindingSource1
            // 
            this.contaCorrenteBindingSource1.DataSource = typeof(CaixaEletronico.ContaCorrente);
            // 
            // contaCorrenteBindingSource2
            // 
            this.contaCorrenteBindingSource2.DataSource = typeof(CaixaEletronico.ContaCorrente);
            // 
            // movimentacaoBindingSource1
            // 
            this.movimentacaoBindingSource1.DataSource = typeof(CaixaEletronico.Movimentacao);
            // 
            // tipoOperacaoBindingSource
            // 
            this.tipoOperacaoBindingSource.DataMember = "_tipoOperacao";
            this.tipoOperacaoBindingSource.DataSource = this.movimentacaoBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarConta,
            this.btnExcluir,
            this.btnRealizarSaque,
            this.btnRealizarDeposito,
            this.btnTransferencia,
            this.btnExtrato,
            this.toolStripSeparator1,
            this.lblTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastrarConta
            // 
            this.btnCadastrarConta.AccessibleDescription = "z";
            this.btnCadastrarConta.Enabled = false;
            this.btnCadastrarConta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarConta.Image")));
            this.btnCadastrarConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarConta.Name = "btnCadastrarConta";
            this.btnCadastrarConta.Size = new System.Drawing.Size(141, 24);
            this.btnCadastrarConta.Text = "Cadastrar Conta";
            this.btnCadastrarConta.Click += new System.EventHandler(this.btnCadastrarConta_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "z";
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 24);
            this.btnExcluir.Text = "Excluir Conta";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRealizarSaque
            // 
            this.btnRealizarSaque.AccessibleDescription = "z";
            this.btnRealizarSaque.Enabled = false;
            this.btnRealizarSaque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarSaque.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarSaque.Image")));
            this.btnRealizarSaque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRealizarSaque.Name = "btnRealizarSaque";
            this.btnRealizarSaque.Size = new System.Drawing.Size(130, 24);
            this.btnRealizarSaque.Text = "Realizar Saque";
            this.btnRealizarSaque.Click += new System.EventHandler(this.btnRealizarSaque_Click);
            // 
            // btnRealizarDeposito
            // 
            this.btnRealizarDeposito.AccessibleDescription = "z";
            this.btnRealizarDeposito.Enabled = false;
            this.btnRealizarDeposito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarDeposito.Image")));
            this.btnRealizarDeposito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRealizarDeposito.Name = "btnRealizarDeposito";
            this.btnRealizarDeposito.Size = new System.Drawing.Size(151, 24);
            this.btnRealizarDeposito.Text = "Realizar Depósito";
            this.btnRealizarDeposito.Click += new System.EventHandler(this.btnRealizarDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.AccessibleDescription = "z";
            this.btnTransferencia.Enabled = false;
            this.btnTransferencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferencia.Image")));
            this.btnTransferencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(123, 24);
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.AccessibleDescription = "z";
            this.btnExtrato.Enabled = false;
            this.btnExtrato.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.Image = ((System.Drawing.Image)(resources.GetObject("btnExtrato.Image")));
            this.btnExtrato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(123, 24);
            this.btnExtrato.Text = "Exibir Extrato";
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // lblTipoCadastro
            // 
            this.lblTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCadastro.Name = "lblTipoCadastro";
            this.lblTipoCadastro.Size = new System.Drawing.Size(71, 24);
            this.lblTipoCadastro.Text = "Cadastro";
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 55);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(893, 354);
            this.panelControl.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 409);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOperacaoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContaCorrenteMenuItem;
        private System.Windows.Forms.BindingSource contaCorrenteBindingSource;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource contaCorrenteBindingSource1;
        private System.Windows.Forms.BindingSource contaCorrenteBindingSource2;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource1;
        private System.Windows.Forms.BindingSource tipoOperacaoBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExtrato;
        private System.Windows.Forms.ToolStripButton btnCadastrarConta;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnRealizarSaque;
        private System.Windows.Forms.ToolStripButton btnRealizarDeposito;
        private System.Windows.Forms.ToolStripButton btnTransferencia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTipoCadastro;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripMenuItem clienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairMenuItem;
    }
}

