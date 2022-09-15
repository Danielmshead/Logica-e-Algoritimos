namespace Exercicio2d
{
    //Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:
    //d)
    //A <- 10
    //B <- A + 1 
    //A <- B +1 
    //B <- A +1
    //Escrever A
    //A <- A + 1
    //Escrever A, B
    class LogEx2d
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = a + 1;
            a = b + 1;
            b = a + 1;

            Console.WriteLine("Resultado A = " + a);

            a = b + 1;

            Console.WriteLine("Resultado A = " + a + ", " + b);

        }
    }
}





