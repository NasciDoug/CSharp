using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;

            Console.Write("Digite o número desejado: ");
            num1 = double.Parse(Console.ReadLine());

            if (num1>200 || num1<300)
            {
                Console.WriteLine("O {0} está entre 200 e 300  (200 < {0} < 300)", num1);
            }
            else
            {
                Console.Write("Fim    ");
            }

            Console.ReadKey();
        }
    }
}
