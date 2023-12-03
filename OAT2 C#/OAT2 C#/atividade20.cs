using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade20
    {
        public void atividade_20()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int maior = 0;
            int menor = 0;
            int multiplicacao = 0;
            double divisao = 0;

            Console.WriteLine("Informe o valor de a: ");
            a= int.Parse(Console.ReadLine());
                
                while (a < 0)
                {
                Console.WriteLine("Valor invalido. Tente novamente!");
                a = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("Informe o valor de b: ");
            b = int.Parse(Console.ReadLine());

                while (b < 0) 
                {
                    Console.WriteLine("Valor invalido. Tente novamente!");
                    b = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("Informe o valor de c: ");
            c = int.Parse(Console.ReadLine());

                while (c < 0) 
                {
                Console.WriteLine("Valor invalido. Tente novamente!");
                c = int.Parse(Console.ReadLine());
                }

            maior = Math.Max(a, Math.Max(b, c));
            menor = Math.Min(a, Math.Min(b, c));

            multiplicacao = menor * maior;
            divisao = maior / menor;

            Console.WriteLine("O Menor valor multiplicado pelo maior é: " + multiplicacao);
            Console.WriteLine("O Maior valor dividido pelo menor é " + divisao);

            Console.ReadKey();
        }
    }
}
