using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class ConsultaBanco
    {
        private List<Conta> contas;

        public ConsultaBanco ()
        {
            contas = new List<Conta>();
        }

        public void AddConta(Cliente nConta)
        {
            contas.Add(nConta.ContaCliente);
        }

    }
}
