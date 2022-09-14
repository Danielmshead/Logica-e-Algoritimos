namespace Exercicio6
{
    class Ex6
    {
        static void Main(string[] args)
        {
            double _base, altura;

            Console.WriteLine("Digite um valor  para a base: ");
            _base = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite um valor  para a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double area = _base * altura;
            Console.WriteLine("Area Total = " + area.ToString());

            Console.ReadKey();
        }
    }
}






