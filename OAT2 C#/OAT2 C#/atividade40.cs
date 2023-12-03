using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade40
    {
        public void atividade_40()
        {
            string resposta = "";
            double indice = 0;

            do
            {

                Console.WriteLine("Informe o indice de poluição media: ");
                indice = int.Parse(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Indice de poluição aceitável.");
                }

                else if (indice > 0.25 && indice <= 0.3)
                {
                    Console.WriteLine("Industrias do 1º grupo intimadas a suspenderem sua atividades.");
                }

                else if (indice > 0.3 && indice <= 0.4)
                {
                    Console.WriteLine("Industrias do 1º e 2º grupos intimadas a suspenderem suas atividades.");
                }

                else if (indice > 0.4 && indice <= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem ser notificados a paralisarem suas atividades.");
                }

                else if (indice > 0.5)
                {
                    Console.WriteLine("Indice de poluição critico");
                }

                else
                {
                    Console.WriteLine("Indice de poluição invalida.");
                }

                Console.WriteLine("Deseja encerrar o programa? 'S' para encerrar: ");
                resposta = Console.ReadLine();

            }
            while (resposta.ToUpper() != "S");

            Console.WriteLine("Programa encerrado.");
            Console.ReadKey();
        }
    }
}
