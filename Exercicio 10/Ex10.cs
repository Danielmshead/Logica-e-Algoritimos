namespace Exercicio10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            int percDistribuidor = 28;
            int percImposto = 45;

            Console.WriteLine("Digite o preço de custo da fabrica: ");
            double valorCustoFabrica = Convert.ToDouble(Console.ReadLine());

            double custoPercDistribuidor = (valorCustoFabrica * percDistribuidor) / 100;
            double custoPercImposto = (valorCustoFabrica * percImposto) / 100;
            double valorTotalConsumidor = valorCustoFabrica + custoPercDistribuidor + custoPercImposto;

            Console.WriteLine("O valor do consumidor  é: R$ " + valorTotalConsumidor.ToString());

            Console.ReadKey();
        }
    }
}






