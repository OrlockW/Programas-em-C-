using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Operador // todo metodo tem que ser publico.
    {
        public int somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            return resultado;
        }

        public int subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            return resultado;
        }

        public int multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            return resultado;
        }

        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            return resultado;
        }

    }

}
