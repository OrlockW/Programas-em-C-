using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            Operador objOperado = new Operador();
            Console.WriteLine("Operador = Digite 1 para somar.");
            Console.WriteLine("Operador = Digite 2 para subtrair.");
            Console.WriteLine("Operador = Digite 3 para multiplicar.");
            Console.WriteLine("Operador = Digite 2 para dividir.");
            string Operador = Console.ReadLine();
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt16(Console.ReadLine());

            if (Operador =="1")
            {
                resultado = objOperado.somar(valor1, valor2);
                Console.WriteLine("O resultado da soma é:" + resultado);
            }

            else if (Operador =="2")
            {
                resultado = objOperado.subtrair(valor1, valor2);
                Console.WriteLine("O resultado da subtração é:" + resultado);
            }

            else if (Operador =="3")
            {
                resultado = objOperado.multiplicar(valor1, valor2);
                Console.WriteLine("O resultado da multiplicação é:" + resultado);
            }

            else if (Operador == "4")
            {
                resultado = objOperado.dividir(valor1, valor2);
                Console.WriteLine("O resultado da divisão é:" + resultado);
            }

            Console.ReadLine();
        }
    }
}
