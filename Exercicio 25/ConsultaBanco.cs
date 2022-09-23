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
        
        public void Saldo(Cliente pessoa, double valor)
        {
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas[i].Id == pessoa.ContaCliente.Id)
                {
                    contas[i].Valor += valor;
                }
            }
        }
        public void Debito(Cliente pessoa, double valor)
        {
            for (int i = 0; i < contas.Count; i--)
            {
                if (contas[i].Id == pessoa.ContaCliente.Id)
                {
                    contas[i].Valor -= valor;
                }
            }
        }

        public void Credito(Cliente pessoa, double valor)
        {
            for (int i = 0; i < contas.Count; i++)
            {
                if(contas[i].Id == pessoa.ContaCliente.Id)
                {
                    contas[i].Valor += valor;
                }
            }
        }

        public double SaldoTotal(Cliente cCliente)
        {
            double saldoTotal = 0;
            for(int i = 0; i < contas.Count; i++)
            {
                if (contas[i].Id == cCliente.ContaCliente.Id)
                {
                    saldoTotal = contas[i].Valor;
                }
            }
            return saldoTotal;
        }
    }
}
