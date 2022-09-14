namespace Exercicio9
{
    class Ex9
    {
        static void Main(string[] args)
        {
            int salarioAtual, perReajuste, novoSalario ;

            Console.WriteLine("Digite o salario atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o percentual do reajuste: ");
            double perReajuste = Convert.ToDouble(Console.ReadLine());

            double novoSalario = salarioAtual + (salarioAtual * (perReajuste / 100));
            Console.WriteLine("O salário foi reajustado para: " + "R$ " + novoSalario.ToString() );

            Console.ReadKey();
        }
    }
}






