using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade22
    {
        public void atividade_22()
        {
            int numero = 0;
            int a = 0;
            int b = 0;

            Console.WriteLine("Informe um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("O numero 0 é neutro. ");
            }

            else if (numero > 0) 
            {
                a = numero;
                Console.WriteLine("O numero positivo foi armazenado em a. ");
            }

            else 
            {
                b = numero;
                Console.WriteLine("O numero negativo foi armazenado em b. ");
            }
            Console.ReadKey();
        }
    }
}
