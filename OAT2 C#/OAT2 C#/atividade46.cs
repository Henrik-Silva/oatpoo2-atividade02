using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade46
    {
        public void atividade_46()
        {
            
            Console.WriteLine("Digite o tamanho dos vetores");
            int tamanho = int.Parse(Console.ReadLine());

            int[] x = new int[tamanho];
            int[] y = new int[tamanho];

            Console.WriteLine("Digite os elementos do vetor x: ");

            for (int i = 0; i < tamanho; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor y: ");

            for (int i = 0; i < tamanho; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }

            int produtoEscalar = 0;

            for (int i = 0; i < tamanho; i++)
            {
                produtoEscalar += x[i] * y[i];
            }

            Console.WriteLine("O produto escalar dos vetores é: " + produtoEscalar);

            Console.ReadKey();
        }
    }
}
