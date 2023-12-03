using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade62
    {
        public void atividade_62()
        {
            double baseValor = 0;
            double alturaValor = 0;
            double hipotenusa = 0;

            Console.WriteLine("Informe o valor da base do triângulo");
            baseValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura do triângulo");
            alturaValor = double.Parse(Console.ReadLine());

            hipotenusa = Hipotenusa(baseValor, alturaValor);

            Console.WriteLine("O valor da hipotenusa com base nos dados fornecidos do triângulo é: {0}", hipotenusa);

            Console.ReadKey();

        }

        public double Hipotenusa(double baseValor, double alturaValor)
        {
            double hipotenusaQ = Math.Pow(baseValor, 2) + Math.Pow(alturaValor, 2);

            double hipotenusa = Math.Sqrt(hipotenusaQ);

            return hipotenusa;
        }
    }
}
