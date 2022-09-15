namespace Exercicio13
{
    // Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno. 
    //Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média
    //final é: 
    //mediaFinal = n1*2+n2*3+n3*5/10

    class Ex13
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota 1: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            int mediaFinal = (nota1 * 2) + (nota2 * 3) + (nota3 * 5) / 10;

            Console.WriteLine("Média final calculada: " + mediaFinal); 

            Console.ReadKey();

        }
    }
}






