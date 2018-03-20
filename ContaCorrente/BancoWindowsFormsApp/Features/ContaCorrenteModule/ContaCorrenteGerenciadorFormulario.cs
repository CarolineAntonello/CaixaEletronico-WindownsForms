using CaixaEletronico;
using CaixaEletronico.Dominio;
using CaixaEletronico.Infra.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using BancoWindowsFormsApp.Compartilhado;

namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    public class ContaCorrenteGerenciadorFormulario : GerenciadorFormulario
    {
        private ContaCorrenteControl _contaCorrenteControl = null;
        private ExtratoControl _ExtratoControl= null;
        private readonly ContaCorrenteMem _repositorioContas = null;
        private ClienteMem _repositorioClientes = null;


        public ContaCorrenteGerenciadorFormulario(ContaCorrenteMem repositorioContas, ClienteMem repositorioClientes)
        {
           
            _repositorioContas = repositorioContas;

            _repositorioClientes = repositorioClientes;
        }

        public override void Adicionar()
        {
            //precisa chamar o repositorio de clientes e gravar em uma lista
            List<Cliente> clientes = _repositorioClientes.SelecionarTodosClientes();
            
            //passar a lista de clientes para o CadastroContaCorrente via contructor
            CadastroContaCorrente dialog = new CadastroContaCorrente(clientes);
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                _repositorioContas.AdicionarConta(dialog.NovaConta);

                AtualizarListagem();
            }
        }
        
        public override UserControl CarregarListagem()
        {
            if (_contaCorrenteControl == null)
                _contaCorrenteControl = new ContaCorrenteControl();

            return _contaCorrenteControl;
        }

        public override void Excluir()
        {
            ContaCorrente contaSelecionada = _contaCorrenteControl.ObtemContaSelecionada();

            DialogResult resultado = MessageBox.Show("Excluir Conta",
                "Tem certeza que deseja excluir a conta?" + contaSelecionada, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioContas.ExcluirConta(contaSelecionada);

                AtualizarListagem();
            }
        }

        public void SacarConta()
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente contaSelecionada = _contaCorrenteControl.ObtemContaSelecionada();
            conta = _repositorioContas.PegarConta(contaSelecionada);

            RealizarSaque dialog = new RealizarSaque(conta);
            DialogResult resultado = dialog.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                _repositorioContas.SacarFinalmente(conta, dialog.PegaValorSaque());
                AtualizarListagem();
            }

            AtualizarListagem();
        }

        public void DepositarConta()
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente contaSelecionada = _contaCorrenteControl.ObtemContaSelecionada();
            conta = _repositorioContas.PegarConta(contaSelecionada);

            RealizarDeposito dialog = new RealizarDeposito(conta);
            DialogResult resultado = dialog.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                _repositorioContas.DepositarFinalmente(conta, dialog.PegaValorDeposito());
                AtualizarListagem();
            }

            AtualizarListagem();
        }

        public void Transferencia()
        {
            ContaCorrente conta = new ContaCorrente();


            List<ContaCorrente> contas = _repositorioContas.SelecionarTodasContas();


            ContaCorrente contaSelecionada = _contaCorrenteControl.ObtemContaSelecionada();
            conta = _repositorioContas.PegarConta(contaSelecionada);

            RealizarTransferencia dialog = new RealizarTransferencia(conta,contas);
            DialogResult resultado = dialog.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                _repositorioContas.TranferirFinalmente(conta, dialog.pegaConta(), dialog.PegaValor());
                AtualizarListagem();
            }

            AtualizarListagem();
        }

        public void Extrato()
        {
            ContaCorrente conta = new ContaCorrente();

            List<ContaCorrente> contas = _repositorioContas.SelecionarTodasContas();

            ContaCorrente contaSelecionada = _contaCorrenteControl.ObtemContaSelecionada();
            conta = _repositorioContas.PegarConta(contaSelecionada);

            


            ExtratoContaCorrente dialog = new ExtratoContaCorrente();
            ListagemMovimentacoes(conta);
            DialogResult resultado = dialog.ShowDialog();

           
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Contas Correntes";
        }


        #region métodos privados
        private void AtualizarListagem()
        {
            List<ContaCorrente> contas = _repositorioContas.SelecionarTodasContas();

            _contaCorrenteControl.PopularListagemContasCorrentes(contas);
        }
        #endregion

        private UserControl CriaExtratoControl()
        {
            if (_ExtratoControl == null)
                _ExtratoControl = new ExtratoControl();

            return _ExtratoControl;
        }


        private void ListagemMovimentacoes(ContaCorrente conta)
        {
            _ExtratoControl.PopularListagemMovimentacoes(conta.movimentacoes);
        }

        public override EstadoBotoes _estadoBotoes()
        {
            EstadoBotoes estado = new EstadoBotoes();

            estado.Cadastrar = true;
            estado.Excluir = true;
            estado.ExibirExtrato = true;
            estado.RealizarDeposito = true;
            estado.RealizarSaque = true;
            estado.Transferencia = true;

            return estado;
        }

        public override TrocarNomeBotoes _nomeBotoes()
        {
            TrocarNomeBotoes trocar = new TrocarNomeBotoes();
            trocar.Cadastrar = "Cadastrar Conta Corrente";
            trocar.Excluir = "Excluir Conta Corrente";
            trocar.ExibirExtrato = "Exibir Extrato da Conta";
            trocar.RealizarDeposito = "Realizar Depósito";
            trocar.RealizarSaque = "Realizar Saque";
            trocar.Transferencia = "Realizar Tranferência";

            return trocar;
        }
    }
}

