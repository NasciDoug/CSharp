using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahren;

            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahren = (9 * celsius + 160) / 5;

            Console.Write("A temperatura {0} graus Celsius é igual a temperatura {1}.", celsius, fahren);

            Console.ReadKey();
        }
    }
}
