using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade38
    {
        public void atividade_38()
        {
            string resposta = "";
            int codigo = 0;
            int horas = 0;
            double salario = 0;
            double salarioEx = 0;
            double horasEx = 0;

            do
            {
                Console.WriteLine("Informe o codigo do operario: ");
                codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o numero de horas trabalhadas: ");
                horas = int.Parse(Console.ReadLine());

                if (horas > 50)
                {
                    horasEx = horas - 50;
                    salario = 50 * 10;
                    salarioEx = horasEx * 20;
                }

                else
                {
                    salario = horas * 10;
                }

                Console.WriteLine("Salario total: " + salario + "Reais");
                Console.WriteLine("Salario excedente: " + salarioEx + "Reais");
                Console.WriteLine("Deseja encerrar o programa? 'S' para sim");
                resposta = Console.ReadLine();

            }

            while (resposta.ToUpper() != "S");

            Console.WriteLine("Programa encerrado");
            Console.ReadKey();
        }
    }
}
