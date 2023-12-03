using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade12
    {
        public void atividade_12()
        {
            int valorinteiro = 0;
            int moduloN = 0;

            Console.WriteLine("Informe o numero inteiro: ");
            valorinteiro = int.Parse(Console.ReadLine());

            if (valorinteiro >= 0) 
            {
                moduloN = valorinteiro;
                Console.WriteLine("O modulo do numero escolhido é: " + moduloN);
            }

            else
            {
                moduloN = valorinteiro * (-1);
                Console.WriteLine("O modulo do valor escolhido é: " + moduloN);
            }

            Console.ReadKey();
        }
    }
}
