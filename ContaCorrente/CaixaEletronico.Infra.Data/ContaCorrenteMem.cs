using System;
using System.Collections.Generic;


namespace CaixaEletronico.Infra.Data
{
    public class ContaCorrenteMem
    {
        private List<ContaCorrente> contas = new List<ContaCorrente>();
        public void AdicionarConta(ContaCorrente novaConta)
        {
            if (ContaCorrenteExistente(novaConta))
                return;

            if (novaConta != null)
                contas.Add(novaConta);
        }


        private bool ContaCorrenteExistente(ContaCorrente novaConta)
        {
            foreach (var item in contas)
            {
                if (novaConta.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public List<ContaCorrente> SelecionarTodasContas()
        {
            return contas;
        }

        public void ExcluirConta(ContaCorrente contaselecionada)
        {
            if (ContaCorrenteExistente(contaselecionada))
            {
                contas.Remove(contaselecionada);
            }
        }

        public ContaCorrente PegarConta(ContaCorrente contaselecionada)
        {
            if (ContaCorrenteExistente(contaselecionada))
            {
                return contaselecionada;

            }
            return null;
        }

        public void SacarFinalmente(ContaCorrente conta , Double valor)
        {
            conta.Sacar(valor,0);

        }

        public void DepositarFinalmente(ContaCorrente conta, Double valor)
        {
            conta.Depositar(valor, 1);
        }

        public void TranferirFinalmente(ContaCorrente conta, ContaCorrente contaDestino, Double valor)
        {
            conta.Transferencia(conta, contaDestino, valor);
        }

       
    }
}

