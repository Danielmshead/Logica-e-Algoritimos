namespace Exercicio17
{
    //Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média aritmética simples e escrever 
    //uma mensagem que diga se o aluno foi ou não aprovado(considerar que nota igual ou maior que 6 o
    //aluno é aprovado). Escrever também a média calculada.
    class Ex17
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a nota 1: ");
            double nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double nota2 = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
            Console.WriteLine(media.ToString());

            Console.ReadKey();
        }
    }
}







