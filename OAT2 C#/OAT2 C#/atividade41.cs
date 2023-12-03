using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade41
    {
        public void atividade_41()
        { 
            int idade = 0;
            string categoria = "";

            Console.WriteLine("Informe a idade do nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                categoria = "Infantil A";
            }

            else if (idade >= 8 && idade <= 11)
            {
                categoria = "Infantil B";
            }

            else if (idade >= 12 && idade <= 13)
            {
                categoria = "Juvenil A";
            }

            else if (idade >= 14 && idade <= 17)
            {
                categoria = "Juvenil B";
            }

            else if (idade >= 18)
            {
                categoria = "Adultos";
            }

            else
            {
                Console.WriteLine("Idade invalida. Tente novamente.");
                return;
            }

            Console.WriteLine("O nadador pertence a categoria: " + categoria);
            Console.ReadKey();
        }
    }
}
