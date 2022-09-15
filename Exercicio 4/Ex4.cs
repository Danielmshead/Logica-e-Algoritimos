namespace Exercicio4
{
    //Reescreva as instruções abaixo com o mínimo de parênteses possível, mas sem alterar o
    //resultado: 
    class Ex4
    {
        static void Main(string[] args)
        {
            float a1, a2, b1, b2, c1, c2, d1, d2, e1, e2, f1, f2, g1, g2, h1, h2, i1, i2, j1, j2;

            a1 = 6 * (3 + 2);
            a2 = 6 * 5;
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine("a2 = " + a2);

            b1 = 2 + (6 * (3 + 2));
            b2 = 2 + 30;
            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("b2 = " + b2);

            c1 = 2 + (3 * 6) / (2 + 4);
            c2 = 2 + 18 / 6;
            Console.WriteLine("c1 = " + c1);
            Console.WriteLine("c2 = " + c2);

            d1 = 2 * (8 / (3 + 1));
            d2 = 2 * 2;
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);

            e1 = 3 + (16 - 2) / (2 * (9 - 2));
            e2 = 3 + 14 / 14;
            Console.WriteLine("e1 = " + e1);
            Console.WriteLine("e2 = " + e2);

            f1 = (6 / 3) + (8 / 2);
            f2 = 2 + 4;
            Console.WriteLine("f1 = " + f1);
            Console.WriteLine("f2 = " + f2);

            g1 = ((3 + (8 / 2)) * 4) + (3 * 2);
            g2 = 7 * 4 + 6;
            Console.WriteLine("g1 = " + g1);
            Console.WriteLine("g2 = " + g2);

            h1 = (6 * (3 * 3) + 6) - 10;
            h2 = 60 - 10;
            Console.WriteLine("h1 = " + h1);
            Console.WriteLine("h2 = " + h2);

            i1 = (((10 * 8) + 3) * 9);
            i2 = (83 * 9);
            Console.WriteLine("i1 = " + i1);
            Console.WriteLine("i2 = " + i2);

            j1 = ((-12) * (-4)) + (3 * (-4));
            j2 = 48 - 12 ;
            Console.WriteLine("j1 = " + j1);
            Console.WriteLine("j2 = " + j2);
        }
    }
}





