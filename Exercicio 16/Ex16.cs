namespace Exercicio16
{
    //As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem 
    //compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
    //escreva o custo total da compra.
    class Ex16
    {
        static void Main(string[] args)
        {
            int qtdMarcas = Convert.ToInt32(Console.ReadLine());

            double totalCompras = 0;
            double valorUnit = 0;

            if (qtdMarcas < 12)
            {
                valorUnit = 1.30;
            }
            else
            {
                valorUnit = 1;
            }

            totalCompras = qtdMarcas * valorUnit;
            Console.WriteLine("Valor Total: " + totalCompras.ToString());
            Console.ReadKey();
        }
    }
}







