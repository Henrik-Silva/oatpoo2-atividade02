using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade01
    {
        public void atividade_1()
        {
            int quantidadeMin = 0;
            int quantidadeMax = 0;
            decimal estoqueMed = 0;

            Console.WriteLine("Informe a quantidade minima do produto: ");
            quantidadeMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade maxima do produto: ");
            quantidadeMax = int.Parse(Console.ReadLine());

            estoqueMed = (quantidadeMin + quantidadeMax) / 2;

            Console.WriteLine("O estoque medio do produto é de: " + estoqueMed);
            Console.ReadKey();
        }
    }
}