using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediafinal;
            Media objmedia = new Media();
            Console.WriteLine("Media = Digite 1 para ver a nota da unip");
            string Media = Console.ReadLine();
            Console.WriteLine("Informe a nota da NP1:");
            double np1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota da NP2:");
            double np2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota do PIM:");
            double pim = Convert.ToDouble(Console.ReadLine());

            if (Media =="1")
            {
                mediafinal = objmedia.Mediaunip(np1, np2, pim);
                Console.WriteLine("Sua media na UNIP é:" + mediafinal);

                if (mediafinal < 5)
                {
                    Console.WriteLine("REPROVADO");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("APROVADO");
                    Console.ReadLine();
                }
            }



            Console.ReadLine();
            

        }
    }
}
