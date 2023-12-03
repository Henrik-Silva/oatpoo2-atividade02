using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade56
    {
        public void atividade_56()
        {
            int[] vetor = new int[50];
            int qtdPares = 0;
            int qtdMultiplosDeCinco = 0;

            Console.WriteLine("Digite um vetor de 50 números inteiros positivos:");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + ": ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    qtdPares++;
                }

                if (vetor[i] % 5 == 0)
                {
                    qtdMultiplosDeCinco++;
                }
            }

            Console.WriteLine("Quantidade de números pares: " + qtdPares);
            Console.WriteLine("Quantidade de múltiplos de 5: " + qtdMultiplosDeCinco);

            Console.ReadKey();
        }
    }
}
