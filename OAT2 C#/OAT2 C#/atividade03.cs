using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2_C_
{
    public class atividade03
    {
        public void atividade_03()
        {
            string nomeVendedor = "";
            int peca = 0;
            double precoPeca = 0;
            int quantidadePecasVendidas = 0;
            double valorTotal = 0;
            double percentual = 0;
            double comissao = 0;
            double ValorTotalComComissao = 0;

            Console.WriteLine("Nome do vendedor: ");
            nomeVendedor = Console.ReadLine();

            Console.WriteLine("Informe o codigo da peça: ");
            peca = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço unitario da peça: ");
            precoPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de peças vendidas: ");
            quantidadePecasVendidas = int.Parse(Console.ReadLine());

            valorTotal = precoPeca + quantidadePecasVendidas;
            percentual = 5.0 / 100.0;
            comissao = valorTotal * percentual;
            ValorTotalComComissao = valorTotal + comissao;

            Console.WriteLine("O valor total a ser recebido pelo vendedor" + nomeVendedor + "é de: " + ValorTotalComComissao.ToString("F2"));
            Console.ReadKey();

        }
    }
}
