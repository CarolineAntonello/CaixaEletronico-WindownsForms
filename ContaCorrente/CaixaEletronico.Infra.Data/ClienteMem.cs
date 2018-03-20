using CaixaEletronico.Dominio;
using System.Collections.Generic;

namespace CaixaEletronico.Infra.Data
{
    public class ClienteMem
    {
        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> SelecionarTodosClientes()
        {
            return clientes;
        }

        public void AdicionarClientes(Cliente novoCliente)
        {
            if (ClienteExistente(novoCliente))
            {
                return;
            }

            if (novoCliente != null)
            {
                clientes.Add(novoCliente);
            }
        }

        private bool ClienteExistente(Cliente novoCliente)
        {
            foreach (var item in clientes)
            {
                if (novoCliente.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void ExcluirCliente(Cliente contaselecionada)
        {
            if (ClienteExistente(contaselecionada))
            {
                clientes.Remove(contaselecionada);
            }
        }
    }
}

