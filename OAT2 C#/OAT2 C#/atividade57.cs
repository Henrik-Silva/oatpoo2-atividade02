using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade57
    {
        public void atividade_57()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            string vogais = "aeiouAEIOU";

            foreach (char letra in frase)
            {
                if (vogais.IndexOf(letra) >= 0)
                {
                    Console.WriteLine(letra);
                }
            }

            Console.ReadKey();
        }
    }
}
