namespace Exercicio2f
{
    //Analise os algoritmos abaixo e diga o que será impresso na tela ao serem executados:
    //f)
    //X <- 1
    //Y <- 2
    //Z <- Y + X
    //Escrever Z
    //X <- 5
    //Y <- X + Z
    //Escrever X, Y, Z
    class LogEx2f
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 1;
            y = 2;
            z = y - x;

            Console.WriteLine("Resultado Z =  " + z);

            x = 5;
            y = x + z;
            Console.WriteLine("Resultado X,Y e Z =  " + x +", " + y + ", " + z);

        }
    }
}





