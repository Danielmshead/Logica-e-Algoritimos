namespace Exercicio9
{
    //Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
    //Calcular e escrever o valor do novo salário.
    class Ex9
    {
        static void Main(string[] args)
        {
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






