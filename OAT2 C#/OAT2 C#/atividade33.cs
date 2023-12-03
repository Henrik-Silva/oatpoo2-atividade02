using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade33
    {
        public void atividade_33()
        {
            int contador = 0;
            double somaNotas = 0;
            string matricula = "";
            double nota = 0;
            double media = 0;

            Console.WriteLine("Informe as notas dos alunos ou 'sair' para encerrar o programa");

            while (true)
            {
                Console.WriteLine("Informe o numero de matricula ou 'sair': ");
                matricula = Console.ReadLine();

                if (matricula == "sair")
                    break;

                Console.WriteLine("Informe a nota do aluno: ");

                if ( double.TryParse(Console.ReadLine(), out nota))
                    {
                        somaNotas += nota;
                        contador++;
                    }

                else
                {
                    Console.WriteLine("Nota invalida. Tente novamente.");
                }
            }

            if (contador > 0)
            {
                media = somaNotas / contador;
                Console.WriteLine("A media das notas é:" + media);
            }

            else
            {
                Console.WriteLine("Informe o aluno");
            }

            Console.ReadKey();
        }
    }
}
