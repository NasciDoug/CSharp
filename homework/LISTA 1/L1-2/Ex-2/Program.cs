using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma, subt, mult, divi;

            Console.WriteLine("Digite o valor do primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            soma = num1 + num2;

            subt = num1 - num2;

            mult = num1 * num2;

            divi = num1 / num2;


            Console.WriteLine("{0} + {1} = {2}; {0} - {1} = {3}; {0} * {1} = {4}; {0} / {1} = {5}", num1, num2, soma, subt, mult, divi);

            Console.ReadKey();

        }
    }
}
