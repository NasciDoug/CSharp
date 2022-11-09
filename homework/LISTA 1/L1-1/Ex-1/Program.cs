using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basE, altura, area;

            Console.WriteLine("Digite o valor da base do trinângulo (m): ");
            basE = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo (m): ");
            altura = double.Parse(Console.ReadLine());

            area = (basE * altura) / 2;

            Console.WriteLine("A área do triângulo é {0} m²", area);

            Console.ReadKey();



        }
    }
}
