using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade45
    {
        public void atividade_45()
        {
            int tamanho = 0;
            int i = 0;

            Console.WriteLine("Digite o tamanho da sequencia");
            tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            Console.WriteLine("Digite os numeros: ");

            for (i = 0; i < tamanho; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sequencia original: ");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero + " ");
            }

            int[] numerosInvertidos = new int[tamanho];

            for (i = 0; i < tamanho; i++)
            {
                numerosInvertidos[i] = numeros[tamanho - 1 - i];
            }

            Console.WriteLine("Sequencia invertida: ");

            foreach (int numero in numerosInvertidos)
            {
                Console.WriteLine(numero + " ");
            }

            Console.ReadKey();
        }
    }
}
