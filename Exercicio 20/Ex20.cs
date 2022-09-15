namespace Exercicio20
{
    //Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente.  
    class Ex20
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Valores iguais");
            }
            else if (valor1 > valor2)
            {
                Console.WriteLine(valor2);
                Console.WriteLine(valor1);
            }
            else
            {
                Console.WriteLine(valor1);
                Console.WriteLine(valor2);
            }

            Console.ReadKey();
        }
    }
}






