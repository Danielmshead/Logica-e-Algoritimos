using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class Conta
    {
        public int Id { get; set; }
        public double Valor { get; set; }

        public Conta()
        {

        }
        public Conta(int id, double valor)
        {
            Id = id;
            Valor = valor;
        }

        public void Saldo (double valor)
        {
            Valor += valor;
        }
        public void Debito(double valor)
        {
            Valor -= valor;
        }
        public void Credito(double valor)
        {
            Valor += valor;
        }
    }
}
