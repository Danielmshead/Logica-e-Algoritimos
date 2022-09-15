namespace Exercicio2b
{
    //Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:
    //b)
    //A <- 30
    //B <- 20 
    //C <- A + B
    //Escrever C
    //B <- 10
    //Escrever B, C
    //C <- A + B
    //Escrever A, B, C
    class LogEx2b
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 30;
            b = 20;
            c = a + b;
            Console.WriteLine("Resultado C = " + c);

            b = 10;
            Console.WriteLine("Resultado B e C = " + b + ", " + c);

            c = a + b;
            Console.WriteLine("Resultado B e C = " + a + ", " + b + ", " + c);

        }
    }
}





