namespace Exercicio21
{
    //Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os 
    //minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é 
    //de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte. 
    class Ex21
    {
        static void Main(string[] args)
        {
            int horasFimPartida;
            int horasInicioPartida;
            int horasTotais;

            while (true)
            {
                Console.WriteLine("Digite a hora que a partida iniciou: ");
                horasInicioPartida = Convert.ToInt32(Console.ReadLine());
                if ((horasInicioPartida > 24) || (horasInicioPartida < 0))
                {
                    Console.WriteLine("Lembre se que um dia tem 24 horas! ");
                    Console.WriteLine("Digite um valor válido!");
                    Console.WriteLine("----------------------");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ok");
                }

                Console.WriteLine("Digite a hora que a partida finalizou: ");
                horasFimPartida = Convert.ToInt32(Console.ReadLine());

                if ((horasFimPartida > 24) || (horasFimPartida < 0))
                {
                    Console.WriteLine("Lembre se que um dia tem 24 horas! ");
                    Console.WriteLine("Digite um valor válido!");
                    Console.WriteLine("----------------------");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ok");
                }

                if (horasFimPartida > horasInicioPartida)
                {
                    horasTotais = (24 - horasFimPartida) + horasInicioPartida;
                    Console.WriteLine("Duração da partida foi de " + horasTotais + " horas!!");
                }
                if (horasFimPartida < horasInicioPartida)
                {
                    horasTotais = (24 - horasInicioPartida) + horasFimPartida;
                    Console.WriteLine("Duração da partida foi de " + horasTotais + " horas!");
                }
                else if (horasInicioPartida == horasFimPartida)
                {
                    Console.WriteLine("Tempo máximo de duração da partida atingida (24 horas)");
                }

                break;
            }
        }
    }
}