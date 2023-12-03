using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade59
    {    
        public void atividade_59()
        {

            Console.WriteLine("Digite 2 caracteres: ");
            char char1 = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            char char2 = char.ToUpper(Console.ReadKey().KeyChar);

            if (char1 >= 'A' && char1 <= 'Z' && char2 >= 'A' && char2 <= 'Z')
            {
                if (char1 > char2)
                {
                    Console.WriteLine("A segunda letra deve ser maior que a primeira. Por favor, tente novamente.");
                }
                else
                {
                    int numCharEntre = char2 - char1 - 1;
                    Console.WriteLine("O número de caracteres entre eles é: " + numCharEntre);
                }
            }
            else
            {
                Console.WriteLine("Ambos os caracteres devem estar entre A e Z. Por favor, tente novamente.");
            }
        }
    }
}
