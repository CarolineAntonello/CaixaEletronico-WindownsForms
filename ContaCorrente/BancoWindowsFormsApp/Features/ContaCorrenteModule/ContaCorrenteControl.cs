using System.Collections.Generic;
using System.Windows.Forms;
using CaixaEletronico;

namespace BancoWindowsFormsApp.Features.ContaCorrenteModule
{
    public partial class ContaCorrenteControl : UserControl
    {
        public ContaCorrenteControl()
        {
            InitializeComponent();
        }
        public void PopularListagemContasCorrentes(List<ContaCorrente> contas)
        {
            listContasCorrentes.Items.Clear();

            foreach (ContaCorrente c in contas)
            {
                listContasCorrentes.Items.Add(c);
            }
        }

        public ContaCorrente ObtemContaSelecionada()
        {

            ContaCorrente contaSelecionada = (ContaCorrente) listContasCorrentes.SelectedItem;

            return contaSelecionada;

        }
    }
}
