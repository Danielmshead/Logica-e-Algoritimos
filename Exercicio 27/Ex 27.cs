namespace Exercicio27
{
    //Ler um valor e escrever se é positivo, negativo ou zero. 

    class Ex27
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
            Console.WriteLine("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if(valor > 0)
            {
                Console.WriteLine("Valor digitado é positivo " + valor);
            }
            else if(valor < 0)
            {
                Console.WriteLine("Valor digitado é negativo " + valor);
            }
            else if (valor == 0)
            {
                Console.WriteLine("Valor digitado é igual a " + valor);
            }

            Console.ReadKey();  
        }
    }
}
