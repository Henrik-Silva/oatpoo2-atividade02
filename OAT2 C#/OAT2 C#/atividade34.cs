using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade34
    {
        public void atividade_34()
        {
            int numero = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Informe os numeros positivos, caso queira encerrar informe um numero negativo.: ");

            while (true)
            {
                Console.WriteLine("Informe um numero: ");

                if (int.TryParse(Console.ReadLine(), out numero) )
                {

                    if (numero < 0)
                        break;

                    if (numero > maior)
                        maior = numero;

                    if (numero < menor)
                        menor = numero;

                }

                else
                {
                    Console.WriteLine("numero invalido. Tente novamente.");
                }
            }

            if (maior !=int.MinValue && menor !=int.MaxValue) 
            {
                Console.WriteLine("O maior numero é: " + maior);
                Console.WriteLine("O menor numero é: " + menor);
            }

            else
            {
                Console.WriteLine("Numero invalido. Tente novamente.");
            }

            Console.ReadKey();
        }
    }
}
