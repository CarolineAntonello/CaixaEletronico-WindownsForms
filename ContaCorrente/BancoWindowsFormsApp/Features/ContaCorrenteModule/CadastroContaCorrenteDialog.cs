using CaixaEletronico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Dominio;

namespace BancoWindowsFormsApp
{
    public partial class CadastroContaCorrente : Form
    {
        private List<Cliente> clientes;


        public CadastroContaCorrente(List<Cliente> clientes)
        {
            InitializeComponent();

            this.clientes = clientes;

            foreach (var item in clientes)
            {
                cmbTitular.Items.Add(item);
            }
        }


        public ContaCorrente NovaConta
        {
            get
            {
                var conta = new ContaCorrente();

                conta.cliente = (Cliente)cmbTitular.SelectedItem;
                conta._numero = int.Parse(txtNumero.Text);
                conta._saldo = double.Parse(txtSaldo.Text);
                conta._limite = double.Parse(txtLimite.Text);
                conta._statusEspecial = chkEspecial.Checked;

                return conta;
            }
        }

    }
}
