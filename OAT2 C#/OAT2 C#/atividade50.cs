using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade50
    {
        public void atividade_50()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(0, 101);
            int tentativa = 0;
            int tentativas = 0;

            Console.WriteLine("Adivinhe o número sorteado entre 0 e 100.");

            do
            {
                Console.WriteLine("Digite a sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior que " + tentativa + ".");
                }
                else if (tentativa > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor que " + tentativa + ".");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número sorteado.");
                }
            } while (tentativa != numeroSorteado);

            Console.WriteLine("Você acertou o número sorteado após " + tentativas + " tentativas.");

            Console.ReadKey();
        }
    }
}
