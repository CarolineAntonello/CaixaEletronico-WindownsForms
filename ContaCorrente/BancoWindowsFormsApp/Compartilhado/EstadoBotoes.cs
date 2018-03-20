using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoWindowsFormsApp.Compartilhado
{
    public class EstadoBotoes
    {
        public bool Cadastrar { get; internal set; }
        public bool Excluir { get; internal set; }
        public bool RealizarSaque { get; internal set; }
        public bool RealizarDeposito { get; internal set; }
        public bool Transferencia { get; internal set; }
        public bool ExibirExtrato { get; internal set; }

        
    }
}
