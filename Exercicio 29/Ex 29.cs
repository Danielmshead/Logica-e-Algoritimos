using System.Net;

namespace Exercicio29
{
    // Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma dos 2 maiores.

    class Ex29
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

                double sumab = a + b, sumac = a + c, sumbc = b + c;

                if ((a < b) && (a < c))
                {
                    Console.WriteLine("A soma dos 2 maiores valores é " + sumbc);
                }
                else if ((b < a) && (b < c))
                {
                    Console.WriteLine("A soma dos 2 maiores valores é " + sumac);
                }
                else
                {
                    Console.WriteLine("A soma dos 2 maiores valores é " + sumab);
                }

                break;
            }

            Console.ReadKey();
        }
    }
}

