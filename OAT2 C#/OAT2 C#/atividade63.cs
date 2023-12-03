using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade63
    {
        public void atividade_63()
        {
            int num = 0;
            string resultado = "";
            
            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            resultado = Verifica(num);

            Console.WriteLine("O número {0} é {1}", num, resultado);

            Console.ReadKey();
        }

        public string Verifica(int num)
        {
            if (num % 2 == 0)
            {
                return "PAR";

            }
            else
                return "IMPAR";
        }
    }
}
