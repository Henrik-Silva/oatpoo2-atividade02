using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade37
    {
        public void atividade_37()
        {
            bool voltarParaMenu = true;
            int opcao = 0;
            int numero1 = 0;
            int numero2 = 0;
            double resultado = 0;
            string resposta = "";

            while (voltarParaMenu)
            {
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("Informe uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    voltarParaMenu = false;
                    continue;
                }

                Console.WriteLine("Informe o primeiro numero: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado da adição é: " + resultado);
                        break;

                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado da subtração é: " + resultado);
                        break;

                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado da multiplicação é: " + resultado);
                        break;

                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("Resultado da divisão é: " + resultado);
                        }

                        else
                        {
                            Console.WriteLine("Nenhum número pode ser dividido por zero. Tente novamente. ");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção invalida. Tente novamente.");
                        break;
                }

                Console.WriteLine("Deseja retornar para o meu principal? 'S' para sim: ");
                resposta = Console.ReadLine();

                if (resposta.ToUpper() != "S")
                    voltarParaMenu = false;
              
                Console.ReadKey();  
            }
        }
    }
}
