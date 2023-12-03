using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade05
    {
        public void atividade_05()
        {
            double tempoGasto = 0;
            double VelocidadeMedia = 0;
            double disPercorrida = 0;
            double QuantidadeLGastos = 0;

            Console.WriteLine("O Tempo gasto na viagem em minutos: ");
            tempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("O Velocidade media na viagem: ");
            VelocidadeMedia = double.Parse(Console.ReadLine());

            tempoGasto /= 60;
            disPercorrida = tempoGasto * VelocidadeMedia;
            QuantidadeLGastos = disPercorrida / 12;

            Console.WriteLine("A velocidade media é: " + VelocidadeMedia);
            Console.WriteLine("O tempo gasto é: " + tempoGasto);
            Console.WriteLine("A distancia percorrida é: " + disPercorrida);
            Console.WriteLine("A quantidade de litros na viagem é: " + QuantidadeLGastos);

            Console.ReadKey();



        }
    }
}
