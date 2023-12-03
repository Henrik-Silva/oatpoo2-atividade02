using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade16
    {
        public void atividade_16()
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Informe o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2) 
            {
                Console.WriteLine(numero1 + "é maior que: " + numero2);
            }

            else if (numero2 > numero1) 
            {
                Console.WriteLine(numero2 + "é maior que: " + numero1);
            }

            else
            {
                Console.WriteLine(numero1 + "é igual a: " + numero2);
            }

            Console.ReadKey();
        }
    }
}
