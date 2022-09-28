using System.Net;

namespace Exercicio30
{
    // Ler 3 valores (considere que não serão informados valores iguais) e escrevê-los em ordem crescente.

    class Ex30
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
            double a = 0, b = 0, c = 0;

            while (true)
            {
                Console.WriteLine("\nDigite um valor para a: ");
                a = Convert.ToDouble(lerNumeros());

                Console.WriteLine("\nDigite um valor para b: ");
                b = Convert.ToDouble(lerNumeros());

                Console.WriteLine("\nDigite um valor para c: ");
                c = Convert.ToDouble(lerNumeros());

                if ((c == a) || (a == b) || (b == c))
                {
                    Console.WriteLine("\nO valores digitados não podem ser iguais");
                    continue;
                }

                else
                {
                    Console.WriteLine("\nOk");
                    Console.WriteLine("\nVerificando... ");
                }
                if ((a < b) && (b < c) && (c > a) && (c > b))
                {
                    Console.WriteLine("A ordem crescente é: " + a + "," + b + "," + c );
                }
                if ((a < b) && (a < c) && (b > a) && (b > c))
                {
                    Console.WriteLine("A ordem crescente é: " + a + "," + c + "," + b );
                }
                if ((a > b) && (a < c) && (b < a) && (c > a))
                {
                    Console.WriteLine("A ordem crescente é: " + b + "," + a + "," + c);
                }
                if ((c < a) && (c < b) && (b < c) && (b > a))
                {
                    Console.WriteLine("A ordem crescente é: " + c + "," + a + "," + b);
                }
                if ((c < a) && (c < b) && (b < a) && (b > c))
                {
                    Console.WriteLine("A ordem crescente é: " + c + "," + b + "," + a);
                }
                else if((a > b) && (a > c) && (b < c) && (c < a))
                {
                    Console.WriteLine("A ordem crescente é: " + b + "," + c + "," + a);
                }

                break;
            }

            Console.ReadKey();
        }
    }
}


