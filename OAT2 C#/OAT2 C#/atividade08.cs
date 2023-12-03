using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade08
    {
        public void atividade_08()
        {
            double raio = 0;
            double altura = 0;
            double volume = 0;

            Console.WriteLine("Informe o raio da lata de oleo em centimetros: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata de oleo em centimetros: ");
            altura = double.Parse(Console.ReadLine());

            volume = 3.14159 + (raio * raio) * altura;

            Console.WriteLine("O volume da lata de oleo é: " + volume.ToString("F2"));

            Console.ReadKey();
        }
    }
}
