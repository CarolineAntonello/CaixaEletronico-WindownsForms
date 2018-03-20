using BancoWindowsFormsApp.Compartilhado;
using System.Windows.Forms;

namespace BancoWindowsFormsApp
{
   public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();
        public abstract void Excluir();
        public abstract UserControl CarregarListagem();
        public abstract string ObtemTipoCadastro();
        public abstract EstadoBotoes _estadoBotoes();
        public abstract TrocarNomeBotoes _nomeBotoes();
    }
}
