namespace Exercicio11
{
    class Ex11
    {
        static void Main(string[] args)
        {
            int percGanhoValorVenda = 5;

            Console.WriteLine("Digite o total de carros vendidos: ");
            int  totalCarrosVendidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor total das vendas: ");
            double valorTotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o salario fixo do revendedor");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor pago por carro vendido");
            double valorPagoCarroVendido = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = salarioFixo + (totalCarrosVendidos * valorPagoCarroVendido) + ((valorTotalVendas * percGanhoValorVenda) /100);  
            string valorArredondado = Math.Round(salarioFinal, 2).ToString();

            Console.WriteLine("O salario do funcionário é: R$ " + valorArredondado);

            Console.ReadKey();
        }
    }
}






