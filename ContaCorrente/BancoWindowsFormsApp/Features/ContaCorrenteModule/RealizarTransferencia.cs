using CaixaEletronico;
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

namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    public partial class RealizarTransferencia : Form
    {
        private List<ContaCorrente> contas;
        public RealizarTransferencia(ContaCorrente conta, List<ContaCorrente> contas)
        {
            InitializeComponent();

            txtTitular.Text = conta.cliente._nome;


            this.contas = contas;

            foreach (var item in contas)
            {
                cbmDestinatario.Items.Add(item);
            }
        }

        public ContaCorrente pegaConta()
        {
            ContaCorrente conta = (ContaCorrente) cbmDestinatario.SelectedItem;

            return conta;

        }

        public Double PegaValor()
        {
            
            var valor = Double.Parse(txtValor.Text);


            return valor;
        }
    }
}
