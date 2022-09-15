namespace Exercicio14
{
    //Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso 
    //contrário escrever NÃO É MAIOR QUE 10! 
    class Ex14
    {
        static void Main(string[] args)
        {
            int valor = Convert.ToInt32(Console.ReadLine());


            if (valor > 10)
            {
                Console.WriteLine("É MAIOR QUE 10! ");
            }
            else
            {
                Console.WriteLine(" NÃO É MAIOR QUE 10!");
            }

            Console.ReadKey();
        }
    }
}







