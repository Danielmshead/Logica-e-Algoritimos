namespace Exercicio25
{
    // Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e 
    //escrever o saldo atual(saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior
    //ou igual a zero escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'. 

    class Ex25
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
            //ConsultaBanco consultaBanco = new ConsultaBanco();
            //Cliente cliente = new Cliente(86505-0, new Conta(1,8000));

            //consultaBanco.AddConta(cliente);
            //consultaBanco.Saldo(cliente, 5000);
            //consultaBanco.Debito(cliente, 7000);
            //consultaBanco.Credito(cliente, 3000);

            //Console.WriteLine("Cliente " + cliente.NumeroConta + " tem R$" + cliente.ContaCliente.Valor);
            //Console.ReadKey();

            double aCC = 0, saldoAtual = 0, debito = 0, credito = 0;


            Console.WriteLine("\nInsira o número da conta do cliente: ");
            aCC = int.Parse(lerNumeros());

            Console.WriteLine("\nInsira o saldo da conta do cliente: ");
            saldoAtual = int.Parse(lerNumeros());

            Console.WriteLine("\nInsira o debito da conta do cliente: ");
            debito = int.Parse(lerNumeros());

            Console.WriteLine("\nInsira o credito da conta do cliente: ");
            credito = int.Parse(lerNumeros());

            double saldoTotal = (saldoAtual - debito) + credito;
            if (saldoTotal >= 0)
            {
                Console.WriteLine("\nSaldo Total do Cliente é Positivo " + "(R$" + saldoTotal + ")" );
            }
            else
            {
                Console.WriteLine("\nSaldo Total do Cliente é Negativo " + "(R$" + saldoTotal + ")" );
            }

            Console.ReadKey();
        }
    }
}

