using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade27
    {
        public void atividade_27()
        {
            int n = 0;
            int i = 0;
            int num = 0;
            int fatorial = 0;
            int j = 0;

            Console.WriteLine("Informe a quantidade de números a serem processados: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o número a ser processado: ");
                num = int.Parse(Console.ReadLine());
                fatorial = 1;

                for (j = 1; j <= num; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine("O fatorial de " + num + " é: " + fatorial);
            }
            Console.ReadKey();
        }
    }
}
