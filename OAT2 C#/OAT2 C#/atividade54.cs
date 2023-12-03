using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    internal class atividade54
    {
        public void atividade_54()
        {
            int[] A = { 2, 3, 5, 7, 11 };
            int[] B = { 1, 3, 5, 7, 9, 11, 13, 15 };

            Console.WriteLine("Elementos comuns a A e B:");

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        Console.WriteLine(A[i]);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
