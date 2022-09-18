using System.ComponentModel;
using System.Threading.Tasks.Sources;

namespace Exercicio23
{
    //Para o enunciado a seguir foi elaborado um algoritmo em Português Estruturado que contém 
    //erros, identifique os erros no algoritmo apresentado abaixo:
    //Enunciado: Tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule 
    //e mostre seu peso ideal, utilizando as seguintes fórmulas: 
    // -para sexo masculino: peso ideal = (72.7 * altura) - 58
    // - para sexo feminino: peso ideal = (62.1 * altura) - 44.7

                        //inicio
                        //ler nome
                        //ler sexo
                        //se sexo = M então
                        //peso_ideal <- (72.7 * altura) - 58 
                        //senão
                        //peso_ideal <- (62.1 * altura) – 44.7 
                        // fim_se
                        //escrever peso_ideal
                        //fim
    // 
    class Ex23
    {
        static void Main(string[] args)
        {
            double altura = 0, pesoIdeal = 0;
            int sexo;
            string nome;

            Console.WriteLine("Insira um nome : ");
            nome = Console.ReadLine();

            while (true)
            {
                Console.WriteLine(nome + ". Informe o sexo: 1 para Masculino ou 2 para Feminino: ");
                sexo = Convert.ToInt32(Console.ReadLine());
                if ((sexo < 1) || (sexo > 2))
                {
                    Console.WriteLine("Só existem 2 sexos biológicos, " + nome + "!");
                    Console.WriteLine("Digite um valor válido!");
                    Console.WriteLine("-----------------------");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ok");
                }

                Console.WriteLine(nome + ". Digite a altura (Ex: 1,80): ");
                altura = Convert.ToDouble(Console.ReadLine());

                if (sexo == 1)
                {
                    pesoIdeal = Math.Round(72.7 * altura) - 58;
                }
                else
                {
                    pesoIdeal = Math.Round(62.1 * altura) - 44.7;
                }

                Console.WriteLine(nome + ". O peso ideal calculado de acordo com as informações que você inseriu é  " + pesoIdeal + "Kg" !);

                break;
            }
        }
    }
}