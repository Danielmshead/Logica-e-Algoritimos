namespace Exercicio22
{
    // A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais 
    //de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. 
    //Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva
    //o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
    //(considere que o mês possua 4 semanas exatas). 
    class Ex22
    {
        static void Main(string[] args)
        {
            double horasTrab, salHora, salFinal, horasSem;

            Console.WriteLine("Informe o número de horas trabalhadas em um mês: ");
            horasTrab = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o salário por hora: ");
            salHora = Convert.ToDouble(Console.ReadLine());

            horasSem = horasTrab / 4;
            salFinal = horasTrab * salHora;

            if (horasSem <= 40)
            {
                Console.WriteLine(salFinal);
            }
            else
            {
                salFinal = salFinal + ((horasSem - 40) * (salHora * 1.5));
                Console.WriteLine(salFinal);

            }
            Console.ReadKey();

        }
    }
}