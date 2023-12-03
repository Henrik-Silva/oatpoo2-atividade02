using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade02
    {
        public void atividade_2 ()
        {
            decimal cotacao = 0;
            decimal valorDolar = 0;
            decimal valorEmReal = 0;


            Console.WriteLine("Informe a cotação do dolar: ");
            cotacao = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor em dolar: ");
            valorDolar = decimal.Parse(Console.ReadLine());

            valorEmReal = cotacao * valorDolar;

            Console.WriteLine("O valor em dolar convertido para real é : " + valorEmReal);
            Console.ReadKey();
        }
    }
}
