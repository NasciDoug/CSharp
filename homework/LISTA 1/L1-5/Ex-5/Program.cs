using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.Write("{0} é igual a {1}!", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} é diferente de {1}!", num1, num2);
            }

            Console.ReadKey();

        }
    }
}
