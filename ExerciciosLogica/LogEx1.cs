using System.Drawing;
using System.Security.Cryptography;

namespace Exercicio1
{
        //Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B.
        //A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o
        //valor que está em A passe para B e vice-versa.Ao final, escrever os valores que ficaram armazenados
        //nas variáveis.
    class LogEx1
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;

            int bAux = b;
            b = a;
            a = bAux;


            Console.WriteLine("Resultado a = " + a);
            Console.WriteLine("Resultado b = " + b);
            Console.ReadKey();

        }
    }
}





