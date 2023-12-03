using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade21
    {
        public void atividade_21()
        {
            int numero = 0;

            while (true) 
            {
                Console.WriteLine("Informe um numero inteiro ou 0 para encerrar o programa: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                else if (numero > 0)
                {
                    Console.WriteLine("O numero é positivo.");
                }

                else
                {
                    Console.WriteLine("O numero é negativo.");
                }
                Console.ReadKey();
            }
        }
            
    }
}
