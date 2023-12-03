using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade11
    {
        public void atividade_11()
        {
            int a = 0;
            int b = 0;
            int troca = 0;

            Console.WriteLine("Informe o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de b: ");
            b = int.Parse(Console.ReadLine());

            troca = a;
            a = b;
            b = troca;

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            
            Console.ReadKey();
        }
    }
}
