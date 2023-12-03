using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade14
    {
        public void atividade_14()
        {
            int numero1 = 0;
            int numero2 = 0;
            int diferenca = 0;

            Console.WriteLine("Informe o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                diferenca = numero1 - numero2;
                Console.WriteLine("A diferença do numero" + numero1 + " e " + numero2 + " é " + diferenca);
            }
            
            Console.ReadKey();
        }
    }
}
