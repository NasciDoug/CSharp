using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite o número desejado: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("O número digitado é par!");
            }
            else
            {
                Console.Write("O número digitado é impar!");
            }

            Console.ReadKey();
        }
    }
}
