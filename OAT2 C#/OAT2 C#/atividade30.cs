using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade30
    {
        public void atividade_30()
        {
            int numero = 0;
            int i = 0;
            int resultado = 0;

            Console.WriteLine("Informe um numero para criar a tabuada: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("A Tabuada do {0}:", numero);

            for (i = 1; i <= 10;  i++)
            {
                resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.ReadKey();
        }
    }
}
