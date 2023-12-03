using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade47
    {
        public void atividade_47()
        {
            
            Console.WriteLine("Digite o tamanho do vetor");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

            Console.WriteLine("Digite os elementos do vetor: ");

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o número X");
            int x = int.Parse(Console.ReadLine());

            int maiores = 0, menores = 0, iguais = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }

            Console.WriteLine("Quantidade de números maiores que X: " + maiores);
            Console.WriteLine("Quantidade de números menores que X: " + menores);
            Console.WriteLine("Quantidade de números iguais a X: " + iguais);

            Console.ReadKey();
        }
    }
}
