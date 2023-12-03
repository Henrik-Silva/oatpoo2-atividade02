using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade18
    {
        public void atividade_18()
        { 
            int codigo = 0;

            Console.WriteLine("Informe um numero inteiro: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("um");
                    break;

                case 2:
                    Console.WriteLine("dois");
                    break;

                case 3:
                    Console.WriteLine("três");
                    break;

                default:
                    Console.WriteLine("Código inválido");
                    break;

            }

            Console.ReadKey();
        }
    }
}
