namespace Exercicio19
{
    //Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles. 
    class Ex19
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Valores são iguais");
            }
            if (valor1 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }

            Console.ReadKey();
        }
    }
}






