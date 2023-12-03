using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade06
    {
        public void atividade_06()
        {
            double tempCelsius = 0;
            double fahrenheit = 0;

            Console.WriteLine("Informe a temperatura em celsius: ");
            tempCelsius = double.Parse(Console.ReadLine());

            fahrenheit = (9 * tempCelsius + 160) / 5;
            Console.WriteLine("A temperatura convertida para fahrenheit é: " + fahrenheit);

            Console.ReadKey();
        }
    }
}
