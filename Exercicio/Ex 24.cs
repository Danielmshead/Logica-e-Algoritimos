namespace Exercicio24
{
    //Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa.Sabendo-se que
    //ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que
    //ultrapassar este valor, calcular e escrever o seu salário total.

    class Ex24
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
            double salario = 0, vendas = 0, a, b;

            Console.WriteLine("Digite o seu salário: ");
            salario = int.Parse(lerNumeros());

            Console.WriteLine("\nQual o valor total de vendas?");
            vendas = int.Parse(lerNumeros());

            if (vendas > 1500)
            {
                a = vendas * 0.05;
                b = salario + a;
            }
            else
            {
                a = vendas * 0.03;
                b = salario + a;
            }
            Console.WriteLine("\nO salário total é: " + "R$ " + b);
        }
    }
}

