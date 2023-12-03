using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade52
    {
        public void atividade_52()
        {
            int[] numeros = new int[100];
            int quantidade1 = 0;
            int quantidade3 = 0;
            int quantidade4 = 0;
            int contador = 0;

            Console.WriteLine("Digite o " + (contador + 1) + "º número (-1 para encerrar): ");
            int numero = int.Parse(Console.ReadLine());

            while (numero != -1 && contador < 100)
            {
                numeros[contador] = numero;
                contador++;

                Console.WriteLine("Digite o " + (contador + 1) + "º número (-1 para encerrar): ");
                numero = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < contador; i++)
            {
                if (numeros[i] == 1)
                {
                    quantidade1++;
                }
                else if (numeros[i] == 3)
                {
                    quantidade3++;
                }
                else if (numeros[i] == 4)
                {
                    quantidade4++;
                }
            }

            Console.WriteLine("A quantidade acumulada de números é:");
            Console.WriteLine("O número 1 aparece " + quantidade1 + " vezes");
            Console.WriteLine("O número 3 aparece " + quantidade3 + " vezes");
            Console.WriteLine("O número 4 aparece " + quantidade4 + " vezes");

            Console.ReadKey();

        }
    }
}
