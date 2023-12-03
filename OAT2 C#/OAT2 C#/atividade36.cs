using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade36
    {
        public void atividade_36()
        {
            int i = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int soma = 0;
            int valor = 0;
            double media = 0;
            int quantidadeValores = 10;

            Console.WriteLine("Informe 10 valores inteiros e positivos: ");

            for (i = 1; i <= quantidadeValores; i++)
            {
                Console.WriteLine("Valor : " + i);

                if (int.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {

                    if (valor > maior)
                    maior = valor;

                    if (valor < menor)
                    menor = valor;

                    soma += valor;

                }

                else
                {
                    Console.WriteLine("valor incorreto. tente novamente");
                    i--;
                }
            }

            media = (double)soma / quantidadeValores;

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Media: " + media);

            Console.ReadKey();
        }
    }

}
