using CaixaEletronico.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoWindowsFormsApp.Features.ClienteModule
{
    public partial class CadastroClienteDialog : Form
    {
        public CadastroClienteDialog()
        {
            InitializeComponent();
        }


        public Cliente NovoCliente
        {
            get
            {
                var cliente = new Cliente();

                cliente._cpf = int.Parse(txtCpf.Text);
                cliente._nome = txtNome.Text;
                cliente._telefone = int.Parse(txtTelefone.Text);
                cliente._email = txtEmail.Text;

                return cliente;
            }
        }

        private void CadastroClienteDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
