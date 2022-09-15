namespace Exercicio10
{
    //O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do 
    //distribuidor e dos impostos(aplicados ao custo de fábrica). Supondo que o percentual do distribuidor
    //seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro,
    //calcular e escrever o custo final ao consumidor.
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






