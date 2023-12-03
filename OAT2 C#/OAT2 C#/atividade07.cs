using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade07
    {
        public void atividade_07()
        {
            double tempFahrenheit = 0;
            double celsius = 0;

            Console.WriteLine("Informe a temperatura em fahrenheit: ");
            tempFahrenheit = double.Parse(Console.ReadLine());

            celsius = (tempFahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura convertida para celsius é: " + celsius);

            Console.ReadKey();
        }
    }
}
