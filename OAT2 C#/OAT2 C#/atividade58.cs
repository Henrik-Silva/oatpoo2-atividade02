using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade58
    {
        public void atividade_58()
        {
                int qtdNumeros = 0;
                int maior = int.MinValue;
                double soma = 0;
                double media = 0;

                Console.WriteLine("Digite a quantidade de números a serem lidos: ");
                qtdNumeros = int.Parse(Console.ReadLine());

                int[] numeros = new int[qtdNumeros];

                for (int i = 0; i < qtdNumeros; i++)
                {
                    Console.WriteLine("Digite o número " + (i + 1) + ": ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }

                    soma += numeros[i];
                }

                media = soma / qtdNumeros;

                Console.WriteLine("A média dos números lidos é: " + media);
                Console.WriteLine("O maior número lido é: " + maior);
                Console.ReadKey();
        }
    }            
}
