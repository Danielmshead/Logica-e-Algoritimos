namespace PraticandoLogicaEx1
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;

            int bAux = b;
            b = a;
            a = bAux;


            Console.WriteLine("Resultado a = " + a);
            Console.WriteLine("Resultado b = " + b);
            Console.ReadKey();

        }
    }
}





