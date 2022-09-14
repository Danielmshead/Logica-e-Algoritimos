namespace Exercicio8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o total de eleitores");
            float totalEleitores = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o total de votos brancos ");
            float totalVotosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos nulos ");
            float totalVotosNulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de votos válidos ");
            float totalVotosValidos = Convert.ToInt32(Console.ReadLine());

            double percentualVotosBrancos = (totalVotosBrancos * 100 / totalEleitores);
            double percentualVotosNulos = (totalVotosNulos * 100 / totalEleitores);
            double percentualVotosValidos = (totalVotosValidos * 100 / totalEleitores);

            Console.WriteLine("O percentual de votos brancos é de: " + percentualVotosBrancos.ToString() + "%");
            Console.WriteLine("O percentual de votos nulos é de: " + percentualVotosNulos.ToString() + "%");
            Console.WriteLine("O percentual de votos validos é de: " + percentualVotosValidos.ToString() + "%");
            
            Console.ReadKey();
        }
    }
}






