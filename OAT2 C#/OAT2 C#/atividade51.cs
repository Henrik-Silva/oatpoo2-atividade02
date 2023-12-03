using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade51
    {
        public void atividade_51()
        {
            int n = 0;
            int contadorAlunosAcimaDe7 = 0;
            double somaNotas = 0;
            double nota = 0;
            double mediaNotas = 0;

            Console.WriteLine("Digite a quantidade de alunos: ");
            n = int.Parse(Console.ReadLine());

            somaNotas = 0;
            contadorAlunosAcimaDe7 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + (i + 1) + ": ");
                nota = double.Parse(Console.ReadLine());
                somaNotas += nota;

                if (nota > 7.0)
                {
                    contadorAlunosAcimaDe7++;
                }
            }

            mediaNotas = somaNotas / n;

            Console.WriteLine("A média aritmética das notas é: " + mediaNotas);
            Console.WriteLine("Há " + contadorAlunosAcimaDe7 + " alunos com nota acima de 7.0");

            if (contadorAlunosAcimaDe7 == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.0");
            }

            Console.ReadKey();
        }
    }
}
