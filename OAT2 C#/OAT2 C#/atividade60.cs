using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade60
    {
        public void atividade_60()
        {
            double x = 0;
            double y = 0;
            int quadrante = 0;

            Console.WriteLine("Informe o valor de X");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y");
            y = double.Parse(Console.ReadLine());

            quadrante = VerificaQuadrante(x, y);

            Console.WriteLine("O ponto ({0}, {1}), está no quadrante {2}", x, y, quadrante);

            Console.ReadKey();
        }

        public int VerificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {

                return 0;
            }
        }
    }
}
