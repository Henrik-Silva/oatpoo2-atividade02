using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade64
    {
        public void atividade_64()
        {
            int opcao;
            int[] vetor = new int[10];
            int contParesPosImpares = 0;
            int contImparesPosPares = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CARREGAR_VETOR(vetor);
                        break;
                    case 2:
                        LISTAR_VETOR(vetor);
                        break;
                    case 3:
                        EXIBIR_PARES(vetor);
                        break;
                    case 4:
                        EXIBIR_IMPARES(vetor);
                        break;
                    case 5:
                        contParesPosImpares = CONTAR_PARES_POS_IMPARES(vetor);
                        Console.WriteLine("A quantidade de números pares nas posições ímpares é: " + contParesPosImpares);
                        Console.ReadKey();
                        break;
                    case 6:
                        contImparesPosPares = CONTAR_IMPARES_POS_PARES(vetor);
                        Console.WriteLine("A quantidade de números ímpares nas posições pares é: " + contImparesPosPares);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Programa encerrado");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 7);
        }

        static void CARREGAR_VETOR(int[] vetor)
        {
            Console.WriteLine("Carregando vetor...");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor para a posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vetor carregado com sucesso!");
            Console.ReadKey();
        }

        static void LISTAR_VETOR(int[] vetor)
        {
            Console.WriteLine("Listando vetor...");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Posição " + i + ": " + vetor[i]);
            }
            Console.WriteLine("Listagem completa!");
            Console.ReadKey();
        }

        static void EXIBIR_PARES(int[] vetor)
        {
            Console.WriteLine("Exibindo apenas os números pares do vetor...");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine("Posição " + i + ": " + vetor[i]);
                }
            }
            Console.WriteLine("Exibição completa!");
            Console.ReadKey();
        }

        static void EXIBIR_IMPARES(int[] vetor)
        {
            Console.WriteLine("Exibindo apenas os números ímpares do vetor...");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine("Posição " + i + ": " + vetor[i]);
                }
            }
            Console.WriteLine("Exibição completa!");
            Console.ReadKey();
        }

        static int CONTAR_PARES_POS_IMPARES(int[] vetor)
        {
            int contador = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int CONTAR_IMPARES_POS_PARES(int[] vetor)
        {
            int contador = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
