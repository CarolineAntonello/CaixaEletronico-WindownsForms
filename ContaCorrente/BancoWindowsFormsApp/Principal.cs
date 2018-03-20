using BancoWindowsFormsApp.Compartilhado;
using BancoWindowsFormsApp.Features.ClienteModule;
using BancoWindowsFormsApp.Features.ContaCorrenteModule;
using CaixaEletronico;
using CaixaEletronico.Infra.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoWindowsFormsApp
{
    public partial class Principal : Form
    {
     
        private ContaCorrente _contacorrente = new ContaCorrente();
        private GerenciadorFormulario _gerenciador;

        private ContaCorrenteMem _repositorioContas = new ContaCorrenteMem();
        private ClienteMem _repositorioClientes = new ClienteMem();

        private ContaCorrenteGerenciadorFormulario gerenciadorContaCorrente = null;
        private ClienteGerenciadorFormulario gerenciadorCliente = null;

        public Principal()
        {
            InitializeComponent();
            
        }

        private void CarregarCadastro(GerenciadorFormulario gerenciador)
        {
            _gerenciador = gerenciador;

            lblTipoCadastro.Text = _gerenciador.ObtemTipoCadastro();

            UserControl listagem = _gerenciador.CarregarListagem();

            listagem.Dock = DockStyle.Fill;

            panelControl.Controls.Clear();

            panelControl.Controls.Add(listagem);

            EstadoBotoes estado = _gerenciador._estadoBotoes();
            btnCadastrarConta.Enabled = estado.Cadastrar;//enable para habilitar ou desabilitar
            btnExcluir.Enabled = estado.Excluir;
            btnExtrato.Enabled = estado.ExibirExtrato;
            btnRealizarSaque.Enabled = estado.RealizarSaque;
            btnRealizarDeposito.Enabled = estado.RealizarDeposito;
            btnTransferencia.Enabled = estado.Transferencia;

            TrocarNomeBotoes troca = _gerenciador._nomeBotoes();
            btnCadastrarConta.Text = troca.Cadastrar;//enable para habilitar ou desabilitar
            btnExcluir.Text = troca.Excluir;
            btnExtrato.Text = troca.ExibirExtrato;
            btnRealizarSaque.Text = troca.RealizarSaque;
            btnRealizarDeposito.Text = troca.RealizarDeposito;
            btnTransferencia.Text = troca.Transferencia;

        }

        private void btnCadastrarConta_Click(object sender, EventArgs e)
        {
            //EXCEÇÃO SEM TRATAMENTO - caso o usuário queira fazer um cadastro de primeira
           _gerenciador.Adicionar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _gerenciador.Excluir();
        }

        private void ContaCorrenteMenuItem_Click(object sender, EventArgs e)
        {
            if (gerenciadorContaCorrente == null)
            {
                gerenciadorContaCorrente = new ContaCorrenteGerenciadorFormulario(_repositorioContas, _repositorioClientes);
            }

            CarregarCadastro(gerenciadorContaCorrente);
        }

        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            if (gerenciadorCliente == null)
            {
                gerenciadorCliente = new ClienteGerenciadorFormulario(_repositorioClientes);
            }

            CarregarCadastro(gerenciadorCliente);
        }

        private void btnRealizarSaque_Click(object sender, EventArgs e)
        {
            gerenciadorContaCorrente.SacarConta();
        }

        private void btnRealizarDeposito_Click(object sender, EventArgs e)
        {
            gerenciadorContaCorrente.DepositarConta();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            gerenciadorContaCorrente.Transferencia();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            gerenciadorContaCorrente.Extrato();
        }

        private void sairMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
