namespace Exercicio7
{
    //Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade
    //dessa pessoa expressa apenas em dias.Considerar ano com 365 dias e mês com 30 dias.
    class Ex7
    {
        static void Main(string[] args)
        {
            int ano, mes, dia;

            Console.WriteLine("Digite o ano do nascimento");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o mes");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o dia");
            dia = Convert.ToInt32(Console.ReadLine());

            int diasTotais = 0;

            int diasTotaisAnos = ano * 365;
            int diasTotaisMes = mes * 30;

            diasTotais = diasTotaisAnos + dia;

            Console.WriteLine("A quantidade de dias são:  " + diasTotais.ToString());

            Console.ReadKey();
        }
    }
}






