using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade23
    {
        public void atividade_23()
        {
            int opcao = 0;
            int numero1 = 0;
            int numero2 = 0;
            double operacao = 0;

            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Informe a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                operacao = numero1 + numero2;
                Console.WriteLine("A soma dos numeros é: " + operacao);
            }

            else if (opcao == 2) 
            {
                operacao = numero1 - numero2;
                Console.WriteLine("A subtração dos numeros é: " + operacao);
            }

            else if (opcao == 3) 
            {
                operacao = numero1 * numero2;
                Console.WriteLine("A multiplicação dos numeros é: " + operacao);
            }

            else if (opcao == 4)
            {
                operacao = numero1 / numero2;
                Console.WriteLine("A divisão dos numeros é: " + operacao);
            }

            else 
            {
                Console.WriteLine("Algo deu errado!");
            }

            Console.ReadKey();
        }
    }
}
