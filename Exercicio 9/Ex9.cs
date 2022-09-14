namespace Exercicio9
{
    class Ex9
    {
        static void Main(string[] args)
        {
            int salarioAtual, perReajuste, novoSalario ;

            Console.WriteLine("Digite o salario atual: ");
            salarioAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o rejuste: ");
            perReajuste = Convert.ToInt32(Console.ReadLine());

            novoSalario = (salarioAtual * perReajuste / 100);
            Console.WriteLine("O novo salário é: " + novoSalario + salarioAtual + " %" );

            Console.ReadKey();
        }
    }
}






