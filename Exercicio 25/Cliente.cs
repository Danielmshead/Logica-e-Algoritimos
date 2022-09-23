using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class Cliente
    {
        public int NumeroConta { get; set; }

        public Conta ContaCliente { get; set; }
        public Cliente (int nConta)
        {
            NumeroConta = nConta;
        }
        public Cliente(int nConta, Conta contaCliente)
        {
            NumeroConta = nConta;
            ContaCliente = contaCliente;
        }
    }
}
