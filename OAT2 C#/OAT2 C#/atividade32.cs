using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade32
    {
        public void atividade_32()
        {
            int numero = 0;
            int contador = 0;
            int somaQuadrados = 0;
            int i = 0;

            Console.WriteLine("Informe um numero maior que zero e menor que 10: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10)
            {
                for (i = numero; contador < 20; i++)
                {
                    if (i % 2 != 0)
                    {
                        somaQuadrados += i * i;
                        contador++;
                    }
                }

                Console.WriteLine("A soma dos quadrados dos 20 primeiros numeros impares a partir de {0} é {1}", numero, somaQuadrados);
            }

            else
            {
                Console.WriteLine("O numero informado é invalido");
            }

            Console.ReadKey();
        }
    }
}
