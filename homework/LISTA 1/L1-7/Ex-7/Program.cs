using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total;
            int qtd;

            Console.Write("Quantas cópias serão impressas? ");
            qtd = int.Parse(Console.ReadLine());

            if (qtd>200)
            {
                total = qtd * 0.30;

                Console.WriteLine("Total a ser pago: {0}", total);
            }
            else
            {
                total = qtd * 0.50;

                Console.WriteLine("Total a ser pago: {0}", total);
            }

            Console.ReadKey();

        }
    }
}
