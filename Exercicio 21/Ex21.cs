namespace Exercicio21
{
    //Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os 
    //minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é 
    //de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte. 
    class Ex21
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a hora que a partida iniciou: ");
            int horaInicioPartida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora que a partida finalizou: ");
            int horaFimPartida = Convert.ToInt32(Console.ReadLine());

            int tempoTotal = horaFimPartida - horaInicioPartida;

            if (tempoTotal < 0)
            {
                int limite = tempoTotal + 24;
                Console.WriteLine("O jogo teve " + limite + " horas de duração");
            }
            else
            {
                Console.WriteLine("O jogo teve " + tempoTotal + " horas de duração");
            }

            Console.ReadKey();
        }
    }
}