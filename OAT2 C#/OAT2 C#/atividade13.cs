using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade13
    {
        public void atividade_13()
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Digite três números inteiros diferentes:");

            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            numero3 = int.Parse(Console.ReadLine());

            int maior, meio, menor;

            if (numero1 > numero2 && numero1 > numero3)
            {
                maior = numero1;
                if (numero2 > numero3)
                {
                    meio = numero2;
                    menor = numero3;
                }
                else
                {
                    meio = numero3;
                    menor = numero2;
                }
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                maior = numero2;
                if (numero1 > numero3)
                {
                    meio = numero1;
                    menor = numero3;
                }
                else
                {
                    meio = numero3;
                    menor = numero1;
                }
            }
            else
            {
                maior = numero3;
                if (numero1 > numero2)
                {
                    meio = numero1;
                    menor = numero2;
                }
                else
                {
                    meio = numero2;
                    menor = numero1;
                }
            }

            Console.WriteLine("Em ordem decrescente: " + maior + ", " + meio + ", " + menor);
            Console.ReadKey();
        }
    }
}
