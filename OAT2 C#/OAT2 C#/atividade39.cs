using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade39
    {
        public void atividade_39()
        {
            string resposta = "";
            int numero = 0;

            do
            {
                Console.WriteLine("Informe um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Esse numero é par");
                }

                else
                {
                    Console.WriteLine("Esse numero é impar");
                }

                if (numero >= 0)
                {
                    Console.WriteLine("E Esse numero é positivo");
                }

                else
                {
                    Console.WriteLine("E Esse numero é negativo");
                }

                Console.WriteLine("Deseja encerrar o programa? 'S' para encerrar");
                resposta = Console.ReadLine();
            }

            while (resposta.ToUpper() != "S");

                Console.WriteLine("Programa encerrado");
                Console.ReadKey();
        }
    }
}

