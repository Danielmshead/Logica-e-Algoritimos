namespace Exercicio5
{
    //Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor. 
    class Ex5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um valor ");

            int valor = Convert.ToInt32(Console.ReadLine());

            int antecessor = -- valor ;
            Console.WriteLine("O antecessor é: " + antecessor.ToString());
            Console.ReadKey();
        }
    }
}






