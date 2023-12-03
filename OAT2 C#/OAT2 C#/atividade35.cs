using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade35
    {
        public void atividade_35()
        {
            int i = 0;

            for (i = 1; i <= 100; i++ )
            {
                Console.WriteLine( i );

                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
            }

            Console.ReadKey();
        }
    }
}
