using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente conta1 = new ContaCorrente();
            conta1._numero = 111;
            conta1._limite = 5000;

            ContaCorrente conta2 = new ContaCorrente();
            conta2._numero = 222;
            conta2._limite = 2000;


            List<Movimentacao> movs = conta1.EmitirExtrato();
            List<Movimentacao> movs2 = conta2.EmitirExtrato();


            Console.WriteLine("saldo conta1 " + conta1.EmitirSaldo());

            Console.WriteLine("saldo conta2 " + conta2.EmitirSaldo());

            Console.WriteLine("saldo ficou " + conta1.EmitirSaldo());

            Console.WriteLine("Valor não disponível para Saque");

            conta1.Sacar(17000, 0);
            Console.WriteLine("saldo ficou " + conta1.EmitirSaldo());
            conta1.Depositar(4900, 1);
            Console.WriteLine("saldo ficou " + conta1.EmitirSaldo());

            conta1.Transferencia(conta1, conta2, 4000);
            Console.WriteLine("saldo conta1 ficou " + conta1.EmitirSaldo());

            Console.WriteLine("saldo conta2 ficou " + conta2.EmitirSaldo());
            

            Console.WriteLine("\n Extrato conta1 \n");

            for (int i = 0; i < movs.Count; i++)
            {
                Console.WriteLine("Operação de " + movs[i]._nomeOperacao);

                if (movs[i]._nomeOperacao.Equals("Débito"))
                {
                    Console.WriteLine("Valor Retirado " + movs[i]._valor);
                }
                else if (movs[i]._nomeOperacao.Equals("Crédito"))
                {
                    Console.WriteLine("Valor Depositado " + movs[i]._valor);
                }
                else if (movs[i]._nomeOperacao.Equals("Transferência"))
                {
                    Console.WriteLine("Valor Transferido " + movs[i]._valor);
                }
            }
            Console.WriteLine("saldo conta1 ficou " + conta1.EmitirSaldo());








            Console.WriteLine("\n Extrato conta2 \n");

            for (int i = 0; i < movs2.Count; i++)
            {
                Console.WriteLine("Operação de " + movs2[i]._nomeOperacao);

                if (movs2[i]._nomeOperacao.Equals("Débito"))
                {
                    Console.WriteLine("Valor Retirado " + movs2[i]._valor);
                }
                else if (movs2[i]._nomeOperacao.Equals("Crédito"))
                {
                    Console.WriteLine("Valor Depositado " + movs2[i]._valor);
                }
                else if (movs2[i]._nomeOperacao.Equals("Transferência"))
                {
                    Console.WriteLine("Valor Transferido " + movs2[i]._valor);
                }
            }
            Console.WriteLine("saldo conta2 ficou " + conta2.EmitirSaldo());

            Console.ReadLine();

        }
    }
}
