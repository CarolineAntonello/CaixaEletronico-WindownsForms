using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico;

namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    public partial class ExtratoControl : UserControl
    {

        public ExtratoControl()
        {
            InitializeComponent();
        }
        public void PopularListagemMovimentacoes(List<Movimentacao> mov)
        {
            listBoxExtrato.Items.Clear();

            foreach (Movimentacao c in mov)
            {
                listBoxExtrato.Items.Add(c);
            }
        }
    }
}
