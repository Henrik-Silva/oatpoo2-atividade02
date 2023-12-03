using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade43
    {
        public void atividade_43()
        {
            double somaG = 0;
            int numeroQ = 0;
            double primeiroT = 0;
            double razao = 0;

            somaG = primeiroT * (Math.Pow(razao, numeroQ) - 1) / (razao - 1);

            Console.WriteLine("O numero total de graos que o monge esperava receber é: " + somaG);
            Console.ReadKey();
        }
    }
}
