using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade15
    {
        public void atividade_15()
        {
            Console.WriteLine("Digite as quatro notas do aluno:");

            double nota1, nota2, nota3, nota4;
            double media, novaMedia = 0;
            double notaRecuperacao = 0;

            Console.WriteLine("Informe a Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Média do aluno: " + media.ToString("F2"));

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno em recuperação.");
                Console.Write("Digite a nota da recuperação: ");
                notaRecuperacao = double.Parse(Console.ReadLine());

                novaMedia = (media + notaRecuperacao) / 2;

                Console.WriteLine("Nova média do aluno: " + novaMedia.ToString("F2"));

                if (novaMedia >= 7)
                {
                    Console.WriteLine("Aluno aprovado na recuperação!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.ReadKey();
            }
        }
    }
}
