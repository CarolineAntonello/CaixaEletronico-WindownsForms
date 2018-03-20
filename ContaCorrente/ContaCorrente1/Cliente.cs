using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Dominio
{
    public class Cliente
    {
        public int _cpf;
        public string _nome;
        public int _telefone;
        public string _email;

        public override string ToString()
        {
            return string.Format("Nome: {0} - CPF: {1}", _nome,_cpf);
        }

    }
}
