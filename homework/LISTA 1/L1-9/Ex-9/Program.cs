using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O número {0} é maior que o número {1}", num1, num2);
            }
            else
            {
                if (num2 > num1)
                {
                    Console.WriteLine("O número {1} é maior que o número {0}", num1, num2);
                }
                else
                {
                    Console.WriteLine("Os dois números são iguais ({0} e {1})", num1, num2);
                }
            }

            Console.ReadKey();
        }
    }
}
