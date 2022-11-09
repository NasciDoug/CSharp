using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahren;

            Console.Write("Digite o valor da temperatura em Fahrenheit: ");
            fahren = double.Parse(Console.ReadLine());

            celsius = ((fahren - 32) * 5) / 9;

            Console.Write("A temperatura {0} Fahrenheit é igual a temperaura {1} graus Celsius.", fahren, celsius);

            Console.ReadKey();
        }
    }
}
