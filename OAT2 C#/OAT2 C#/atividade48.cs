using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade48
    {
        public void atividade_48()
        {
            string[] nomes = new string[20]; 
            int[] idades = new int[20];

            Console.WriteLine("Digite o nome e a idade das 20 candidatas: ");

            for (int i = 0; i < 20; i++)
            {

                Console.WriteLine("Nome da candidata" + (i + 1) + ":");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Idade da candidata" + (i + 1) + ":");
                idades[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Candidatas aptas para a campanha publicitaria: ");

            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
