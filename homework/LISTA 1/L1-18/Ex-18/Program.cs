using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, dif1, dif2;

            Console.Write("Digite o primeiro número desejaado: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número desejado: ");
            num2 = int.Parse(Console.ReadLine());


            if(num1>num2)
            {
                dif1 = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, dif1);
            }
            else
            {
                dif2 = num2 - num1;
                Console.WriteLine("{1} - {0} = {2}", num1, num2, dif2);
            }

            Console.ReadKey();
        }
    }
}
