using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade10
    {
        public void atividade_10()
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Informe o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2) 
            {
                Console.WriteLine("Os numeros escolhidos sao iguais");
            }

            else
            {
                Console.WriteLine("Os numeros escolhidos sao diferentes");
            }

            if (numero1 > numero2) 
            {
                Console.WriteLine(numero1 + " é maior que " + numero2);
            }

            else if (numero1 < numero2) 
            {
                Console.WriteLine(numero1 + "é menor que" + numero2);
            }
            
            Console.ReadKey();

        }
    }
}
