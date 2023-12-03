using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade44
    {
        public void atividade_44()
        {
            double grausCelsius = 0;
            double grausFahrenheit = 0;
            string opcao = "";
            double altura = 0;
            double pesoIdeal = 0;

            do
            {
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("S - Sair");
                Console.WriteLine("Informe a opção desejada: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Informe a temperatura em Graus Celsius: ");
                        grausCelsius = double.Parse(Console.ReadLine());
                        grausFahrenheit = grausCelsius * 9 / 5 + 32;
                        Console.WriteLine("A temperatura em Graus Fahrenheit é: " + grausFahrenheit);
                        break;
                    case "2":
                        Console.WriteLine("Informe a temperatura em Graus Fahrenheit: ");
                        grausFahrenheit = double.Parse(Console.ReadLine());
                        grausCelsius = (grausFahrenheit - 32) * 5 / 9;
                        Console.WriteLine("A temperatura em Graus Celsius é: " + grausCelsius);
                        break;
                    case "3":
                        Console.WriteLine("Informe a altura em metros: ");
                        altura = double.Parse(Console.ReadLine());
                        pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal + " kg");
                        break;
                    case "4":
                        Console.WriteLine("Informe a altura em metros: ");
                        altura = double.Parse(Console.ReadLine());
                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal + " kg");
                        break;
                    case "S":
                        Console.WriteLine("Programa encerrado");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.ReadKey();

            } while (opcao.ToUpper() != "S");
            Console.ReadKey();
        }
    }
}

