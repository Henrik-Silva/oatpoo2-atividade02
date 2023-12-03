using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade28
    {
        public void atividade_28()
        {
            int i = 0;

            Console.WriteLine("Os numeros impares entre 100 e 200: ");

            for (i = 101; i<=199; i+=2 )
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
