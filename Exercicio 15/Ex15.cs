namespace Exercicio15
{
    //Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo). 
    class Ex15
    {
        static void Main(string[] args)
        {
            int valor = Convert.ToInt32(Console.ReadLine());


            if (valor >= 0)
            {
                Console.WriteLine("Número é positivo");
            }
            else
            {
                Console.WriteLine("Número é negativo");
            }

            Console.ReadKey();
        }
    }
}







