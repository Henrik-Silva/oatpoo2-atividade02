using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade55
    {
        public void atividade_55()
        {
            Console.WriteLine("Digite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();
            int qtdEspacos = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    qtdEspacos++;
                }
            }

            Console.WriteLine("Frase sem espaços em branco: " + frase.Replace(" ", ""));
            Console.WriteLine("Quantidade de espaços em branco: " + qtdEspacos);

            Console.ReadKey();
        }
    }
}
