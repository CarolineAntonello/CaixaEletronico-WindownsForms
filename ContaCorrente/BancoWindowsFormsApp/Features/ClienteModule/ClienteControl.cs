using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Dominio;

namespace BancoWindowsFormsApp.Features.ClienteModule
{
    public partial class ClienteControl : UserControl
    {
        public ClienteControl()
        {
            InitializeComponent();
        }

        public void PopularListagemClientes(List<Cliente> cliente)
        {
            listClientes.Items.Clear();

            foreach (Cliente c in cliente)
            {
                listClientes.Items.Add(c);
            }
        }

        public Cliente ObtemCliente()
        {
            Cliente clienteSelecionado = (Cliente)listClientes.SelectedItem;

            return clienteSelecionado;
        }
    }
}
