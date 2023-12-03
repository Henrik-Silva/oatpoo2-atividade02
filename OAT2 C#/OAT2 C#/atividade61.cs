using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade61
    {
        public void atividade_61()
        {
            double salario = 0;
            double indice = 0;
            double salarioAtualizado = 0;
            
            Console.WriteLine("Digite o valor do salário");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o indice de reajuste");
            indice = double.Parse(Console.ReadLine());

            salarioAtualizado = Reajuste(salario, indice);

            Console.WriteLine("O salário após o reajuste fica no valor de: R$ {0} reais", salarioAtualizado);

            Console.ReadKey();
        }
        public double Reajuste(double salario, double indice)
        {
            double reajuste = salario * (indice / 100);

            double salarioTotal = salario + reajuste;

            return salarioTotal;
        }
    }
}
