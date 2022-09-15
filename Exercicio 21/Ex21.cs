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

            int horasTotais = (horaFimPartida - horaInicioPartida);

            if (horaInicioPartida == horaFimPartida)
            {
                Console.WriteLine("Tempo máximo de duração da partida atinguida: 24 horas");
            }
            if (horaFimPartida >= horaInicioPartida)
            {
                Console.WriteLine("Duração da partida foi de " + horasTotais + " horas");
            }
            else
            {
                horasTotais = (24 - horaInicioPartida) + horaFimPartida;
                Console.WriteLine("Duração da partida foi de " + horasTotais + " horas");
            }

            Console.ReadKey();
        }
    }
}