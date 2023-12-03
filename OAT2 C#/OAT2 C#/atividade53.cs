using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade53
    {
        public void atividade_53()
        {
            Console.Write("Digite o número de voltas (N): ");
            int n = int.Parse(Console.ReadLine());

            int[] tempos = new int[n];
            int melhorTempo = int.MaxValue;
            int melhorVolta = 0;
            int somaTempos = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o tempo da " + (i + 1) + "ª volta: ");
                tempos[i] = int.Parse(Console.ReadLine());

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    melhorVolta = i + 1;
                }

                somaTempos += tempos[i];
            }

            double tempoMedio = (double)somaTempos / n;

            Console.WriteLine("Melhor tempo: " + melhorTempo);
            Console.WriteLine("Melhor tempo ocorreu na volta " + melhorVolta);
            Console.WriteLine("Tempo médio das " + n + " voltas: " + tempoMedio);

            Console.ReadKey();
        }
    }
}
