using CaixaEletronico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaCorrente
    {
        public int _Id { get; set; }
        public int _numero;
        public double _saldo;
        public Boolean _statusEspecial;
        public double _limite;
        public Cliente cliente;


        public List<Movimentacao> movimentacoes = new List<Movimentacao>();

        public double Sacar(double valor, int op)
        {
            if (valor > _limite + _saldo)
            {

                return 0;
            }
            else
            {
                adicionaMovimentacao(valor, op);
                _saldo = _saldo - valor;
                return valor;

            }
        }
        //Método utilizado para adicionar movimentações
        public void adicionaMovimentacao(double valor, int op)
        {
            Movimentacao mov = new Movimentacao(valor, op);
            movimentacoes.Add(mov);

        }

        public double Depositar(double valor, int op)
        {
            _saldo = _saldo + valor;
            adicionaMovimentacao(valor, op);
            return _saldo;
        }
        public double EmitirSaldo()
        {
            return _saldo;
        }
        public List<Movimentacao> EmitirExtrato()
        {
            return movimentacoes;
        }
        public double Transferencia(ContaCorrente contaSaque, ContaCorrente contaDeposita, double valor)
        {
            double dinheiro;

            dinheiro = contaSaque.Sacar(valor, 2);
            contaDeposita.Depositar(dinheiro, 2);
            return contaSaque._saldo;
        }

        public ContaCorrente(int ID, int numero, double limite, double saldo)

        {
            _Id = ID;
            _numero = numero;
            _limite = limite;
            _saldo = saldo;
        }
        public ContaCorrente()
        {
            _Id = 0;

        }

        public override string ToString()
        {
            return string.Format("Número: {0} - Saldo: {1}", this._numero, this._saldo);
        }

    }
}
