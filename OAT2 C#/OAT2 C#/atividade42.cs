using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade42
    {
        public void atividade_42()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int numero = 0;

            Console.WriteLine("Informe os numeros desejados, Digite '0' para parar");

            do
            {
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
            }
            while (numero != 0);
            {
                Console.WriteLine("O maior informado é: " + maior);
                Console.WriteLine("O menor numero informado é: " + menor);
            }
            Console.ReadKey();  
        }
    }
}
