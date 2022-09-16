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
            int horasInicioPartida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora que a partida finalizou: ");
            int horasFimPartida = Convert.ToInt32(Console.ReadLine());

            if (horasInicioPartida > horasFimPartida)
            {
                int horasTotais = (24 - horasInicioPartida) + horasFimPartida;
                Console.WriteLine("Duração da partida foi de " + horasTotais + " horas!!");
            }
            if (horasInicioPartida < horasFimPartida)
            {
                int horasTotais = horasFimPartida - horasInicioPartida;
                Console.WriteLine("Duração da partida foi de " + horasTotais + " horas!");
            }
            else if (horasInicioPartida == horasFimPartida)
            {
                Console.WriteLine("Tempo máximo de duração da partida atingida (24 horas)" );
            };

            Console.ReadKey();
        }
    }
}