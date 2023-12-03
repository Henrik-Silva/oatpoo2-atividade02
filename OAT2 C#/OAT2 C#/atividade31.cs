using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade31
    {
        public void atividade_31()
        {
            int numero = 0;
            int somaPares = 0;
            int somaImpares = 0;

            Console.WriteLine("Informe um conjunto de numeros positivos ( caso queira encerrar digite um numero negativo!");

            do
            {
                Console.WriteLine("Informe um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("O {0} é par", numero);
                        somaPares += numero;
                    }

                    else
                    {
                        Console.WriteLine("O {0} é impar", numero);
                        somaImpares += numero;
                    }
                }
            }
            while (numero >= 0);

            Console.WriteLine("A soma dos numeros pares é: " + somaPares);
            Console.WriteLine("A soma dos numeros impares é: " + somaImpares);
            
            Console.ReadKey();
        }
    }
}
