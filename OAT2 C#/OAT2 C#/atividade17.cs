using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade17
    {
        public void atividade_17()
        {
            int valor = 0;

            Console.WriteLine("Informe um valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor > 0 && valor < 9)
            {
                Console.WriteLine("Valor valido.");
            }

            else
            {
                Console.WriteLine("Valor invalido");
            }
            
            Console.ReadKey();
        }
    }
}
