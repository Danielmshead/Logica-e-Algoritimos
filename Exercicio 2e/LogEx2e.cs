namespace Exercicio2e
{
    //Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:
    //e)
    //A <- 10
    //B <- 5
    //C <- A + B
    //B <- 20
    //A <- 10
    //Escrever A, B, C
    class LogEx2e
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 5;
            c = a + b;
            b = 20;
            a = 10;

            Console.WriteLine("Resultado A,B e C = " + a + ", " + b + ", " + c);

        }
    }
}





