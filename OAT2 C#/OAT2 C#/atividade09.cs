using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade09
    {
        public void atividade_09()
        {
            double idadeA = 0;
            double idadeM = 0;
            double IdadeD = 0;
            double idadeTotalEmD = 0;

            Console.WriteLine("Informe sua idade em anos: ");
            idadeA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em anos + os meses restantes: ");
            idadeM = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade em anos + os meses + os dias restantes: ");
            IdadeD = double.Parse(Console.ReadLine());

            idadeTotalEmD = (idadeA * 365) + (idadeM * 30) + IdadeD;

            Console.WriteLine("A idade total em dias é: " + idadeTotalEmD);

            Console.ReadKey();
        }
    }
}
