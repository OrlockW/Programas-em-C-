using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//O Preço de um veiculo é calculado pelo soma do preço dos impostos(45% do preço de custo)
//Pela a porcentagem dos vendedores (28% do preço de custo). Faça um algoritimo que imprima, marca, modelo e valor final.
//(valor_vei * 45) / 100 e (valor_vei * 28)/100.

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_custo = 0;
            string marca = "";
            String modelo = "";
            double valor_final = 0;
            double valor_comissao = 0;
            double valor_imposto = 0;

            Console.WriteLine("COLOQUE A MARCA DO CARRO :");
            marca = Console.ReadLine();

            Console.WriteLine("COLOQUE O MODELO DO CARRO :");
            modelo = Console.ReadLine();

            Console.WriteLine("COLOQUE O PREÇO DO CARRO");
            valor_custo = Convert.ToDouble(Console.ReadLine());

            valor_imposto = valor_custo * 0.45;
            valor_comissao = valor_custo * 0.28;
            valor_final = valor_custo + valor_imposto + valor_comissao;

            Console.WriteLine("RESULTADO DA SUA PESQUISA\n");
            Console.WriteLine("MARCA:" + marca + "\n");
            Console.WriteLine("MODELO:" + modelo + "\n");
            Console.WriteLine("VALOR DO CARRO:" + valor_final + "\n");

            Console.ReadLine();
        }
    }
}
