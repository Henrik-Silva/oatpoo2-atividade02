using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade04
    {
        public void atividade_04()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            
            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Informe o valor de C: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de D: ");
            d = int.Parse(Console.ReadLine());

            int ab = a + b;
            int ac = a + c;
            int ad = a + d;
            int bc = b + c;
            int bd = b + d;
            int cd = c + d;

            int multi_ab = a * b;
            int multi_ac = a * c;
            int multi_ad = a * d;
            int multi_bc = b * c;
            int multi_bd = b * d;
            int multi_cd = c * d;

            Console.WriteLine("O Resultado das Somas: ");
            Console.WriteLine($"{a} + {b} = {ab}");
            Console.WriteLine($"{a} + {c} = {ac}");
            Console.WriteLine($"{a} + {d} = {ad}");
            Console.WriteLine($"{b} + {c} = {bc}");
            Console.WriteLine($"{b} + {d} = {bd}");
            Console.WriteLine($"{c} + {d} = {cd}");

            Console.WriteLine("o Resultado das multiplicações: ");
            Console.WriteLine($"{a} + {b} = {multi_ab}");
            Console.WriteLine($"{a} + {c} = {multi_ac}");
            Console.WriteLine($"{a} + {d} = {multi_ad}");
            Console.WriteLine($"{b} + {c} = {multi_bc}");
            Console.WriteLine($"{b} + {d} = {multi_bd}");
            Console.WriteLine($"{c} + {d} = {multi_cd}");

            Console.ReadKey();
        }
    }
}
