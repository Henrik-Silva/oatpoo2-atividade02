using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade49
    {
        public void atividade_49()
        {
            Console.WriteLine("Digite o tamanho do vetor V1");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];

            Console.WriteLine("Digite os elementos do vetor V1: ");

            for (int i = 0; i < tamanho; i++)
            {
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor V2: ");

            for (int i = 0; i < tamanho; i++)
            {
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            int iguais = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    iguais++;
                }
            }

            Console.WriteLine("Quantidade de valores idênticos nas mesmas posições: " + iguais);

            Console.ReadKey();
        }
    }
}
