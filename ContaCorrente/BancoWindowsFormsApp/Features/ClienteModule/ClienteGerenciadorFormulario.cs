using CaixaEletronico.Dominio;
using CaixaEletronico.Infra.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using BancoWindowsFormsApp.Compartilhado;

namespace BancoWindowsFormsApp.Features.ClienteModule
{
    public class ClienteGerenciadorFormulario : GerenciadorFormulario
    {

        private ClienteControl _clienteControl = null;
        private readonly ClienteMem _repositorioClientes = null;

       
        public ClienteGerenciadorFormulario(ClienteMem repositorioClientes)
        {
            _repositorioClientes = repositorioClientes;
        }
        

        public override void Adicionar()
        {
            CadastroClienteDialog dialog = new CadastroClienteDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                _repositorioClientes.AdicionarClientes(dialog.NovoCliente);
                List<Cliente> contas = _repositorioClientes.SelecionarTodosClientes();

                _clienteControl.PopularListagemClientes(contas);
            }
        }

        public override void Excluir()
        {
            Cliente contaSelecionada = _clienteControl.ObtemCliente();

            DialogResult resultado = MessageBox.Show("Excluir Cliente",
                "Tem certeza que deseja excluir o cliente?" + contaSelecionada, MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioClientes.ExcluirCliente(contaSelecionada);

                AtualizarListagem();
            }
        }

        public override UserControl CarregarListagem()
        {
            if (_clienteControl == null)
                _clienteControl = new ClienteControl();

            return _clienteControl;
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Clientes";

        }

        #region métodos privados
        private void AtualizarListagem()
        {
            List<Cliente> cliente = _repositorioClientes.SelecionarTodosClientes();

            _clienteControl.PopularListagemClientes(cliente);
        }

        public override EstadoBotoes _estadoBotoes()
        {
            EstadoBotoes estado = new EstadoBotoes();

            estado.Cadastrar = true;
            estado.Excluir = true;
            estado.ExibirExtrato = false;
            estado.RealizarDeposito = false;
            estado.RealizarSaque = false;
            estado.Transferencia = false;

            return estado;
        }

        public override TrocarNomeBotoes _nomeBotoes()
        {
            TrocarNomeBotoes trocar = new TrocarNomeBotoes();

            trocar.Cadastrar = "Cadastrar Cliente";
            trocar.Excluir = "Excluir Conta Cliente";
            trocar.ExibirExtrato = "Exibir Extrato da Conta";
            trocar.RealizarDeposito = "Realizar Depósito";
            trocar.RealizarSaque = "Realizar Saque";
            trocar.Transferencia = "Realizar Tranferência";

            return trocar;
        }
        #endregion

    }
}
