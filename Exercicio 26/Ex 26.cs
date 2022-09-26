namespace Exercicio26
{
    //Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e 
    //quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade 
    //média = quantidade máxima + quantidade mínima)/ 2). Se a quantidade em estoque for maior ou igual 
    //a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar 
    //compra'. 

    class Ex26
    {
        public static string lerNumeros()
        {
            ConsoleKeyInfo cki;
            string entrada = "";
            while (true)
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        if (entrada.Length == 0) continue;
                        entrada = entrada.Remove(entrada.Length - 1);
                        Console.Write("\b \b"); //Remove o último caractere digitado
                    }
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if ((ConsoleKey.D0 <= cki.Key) && (cki.Key <= ConsoleKey.D9) ||
                        (ConsoleKey.NumPad0 <= cki.Key) && (cki.Key <= ConsoleKey.NumPad9))
                    {
                        entrada += cki.KeyChar;
                        Console.Write(cki.KeyChar);
                    }

                }
            return entrada;
        }
        static void Main(string[] args)

        {
            double qAtual = 0, qMax = 0, qMin = 0;

            Console.WriteLine("\nInsira a quantidade atual dos produtos em estoque: ");
            qAtual = int.Parse(lerNumeros());

            Console.WriteLine("\nInsira a quantidade maxima dos produtos em estoque: ");
            qMax = int.Parse(lerNumeros());

            Console.WriteLine("\nInsira a quantidade mínima dos produtos em estoque: ");
            qMin = int.Parse(lerNumeros());

            double qMedia = (qMax - qMin) / 2;
            if (qAtual >= qMedia)
            {
                Console.WriteLine("\nNão efetuar compra");
            }
            else
            {
                Console.WriteLine("\nEfetuar Compra");
            }

            Console.ReadKey();
        }
    }
}