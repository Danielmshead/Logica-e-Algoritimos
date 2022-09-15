namespace Exercicio2c
{
    //Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:
    //c)
    //A <- 10
    //B <- 20 
    //C <- A 
    //B <- 5
    //A <- B
    //Escrever A, B, C
    class LogEx2c
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a;
            b = c;
            a = b;
            Console.WriteLine("Resultado A, B e C = " + a + ", " + b + ", " + c);

        }
    }
}





