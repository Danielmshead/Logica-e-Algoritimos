namespace Exercicio12
{
    //Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor
    //correspondente em graus Celsius(baseado na fórmula abaixo): 
    // C/5 = F-32/9
    //Observação: Para testar se a sua resposta está correta saiba que 100oC = 212F
    class Ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura para Celsius");
            Console.WriteLine("Digite a temperatura");

            int tempFar = Convert.ToInt32(Console.ReadLine());
            int tempC = (tempFar - 32) * 5 / 9 ;

            Console.WriteLine("A temperatura convertida em Celsius é de:  " + tempC +" C");

            Console.ReadKey();  

        }
    }
}






