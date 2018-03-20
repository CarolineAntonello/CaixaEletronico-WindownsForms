using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Movimentacao
    {
        public double _valor { get; set; }
        public String[] _tipoOperacao { get; set; } = { "Débito", "Crédito", "Transferência" };
        public String _nomeOperacao;

        public Movimentacao(double valor, int op)
        {
            _valor = valor;
            _nomeOperacao = _tipoOperacao[op];

        }
        public Movimentacao(double saldoInicial)
        {

        }


    }
}
