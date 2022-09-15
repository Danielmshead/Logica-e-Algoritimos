namespace Exercicio18
{
    //Ler o ano atual e o ano de nascimento de uma pessoa.Escrever uma mensagem que diga se ela
    //poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu). 
    class Ex18
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            if(idade >= 18)
            {
                Console.WriteLine("A pessoa tem " + idade + " anos de idade");
                Console.WriteLine("Pode votar!");
            }
            else
            {
                Console.WriteLine("A pessoa tem " + idade + " anos de idade");
                Console.WriteLine("Não pode votar!");
            }

            Console.ReadKey();
        }
    }
}







