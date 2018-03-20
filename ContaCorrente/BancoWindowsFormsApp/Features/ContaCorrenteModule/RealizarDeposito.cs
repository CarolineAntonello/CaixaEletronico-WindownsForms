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

namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    public partial class RealizarDeposito : Form
    {
       
        public RealizarDeposito(ContaCorrente conta)
        {
            InitializeComponent();

            txtTitular.Text = conta.cliente._nome;
            txtConta.Text = conta._numero.ToString();
        }

        public Double PegaValorDeposito()
        {

            var valor = Double.Parse(txtValor.Text);


            return valor;
        }

    }
}
