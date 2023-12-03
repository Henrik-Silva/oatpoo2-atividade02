using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade24
    {
        public void atividade_24()
        {
            int numero1 = 0;
            int numero2 = 0;
            int opcao = 0;
            double media = 0;

            while (true)
            {
                Console.WriteLine("Informe o primeiro numero inteiro: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero inteiro: ");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro. ");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares. ");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7. ");
                Console.WriteLine("4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    if (numero1 % numero2 == 0)
                    {
                        Console.WriteLine(numero1 + "É multiplo de: " + numero2);
                    }

                    else
                    {
                        Console.WriteLine(numero1 + "Não é multiplo de: " + numero2);
                    }

                }

                else if (opcao == 2)
                {
                    if (numero1 % 2 == 0 && numero2 % 2 == 0)
                    {
                        Console.WriteLine("Ambos os numeros sao pares. ");
                    }

                    else if (numero1 % 2 == 0)
                    {
                        Console.WriteLine("O numero: " + numero1 + "é par.");
                    }

                    else if (numero2 % 2 == 0)
                    {
                        Console.WriteLine("O numero: " + numero2 + "é par.");
                    }

                    else
                    {
                        Console.WriteLine("Nenhum numero é par. ");
                    }

                }

                else if (opcao == 3)
                {
                    media = (numero1 + numero2) / 2;
                    if (media > 7)
                    {
                        Console.WriteLine("A media da soma dos numeros é maior que 7 ");
                    }

                    else
                    {
                        Console.WriteLine("A media da soma dos numeros é menor que 7 ");
                    }
                }

                else if (opcao == 4)
                {
                    Console.WriteLine("Programa encerrado");
                    break;
                }

                else
                {
                    Console.WriteLine("Opção invalida. Tente novamente");
                }
                Console.ReadKey();
            }
        }
    }
}

