using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.Write("Digite o número desejado: ");
            num = double.Parse(Console.ReadLine());

            if (num >100 && num <200)
            {
                Console.WriteLine("O número digitado está entre 100 e 200 (100 < {0} < 200)", num);
            }
            else
            {
                Console.WriteLine("O número digita não está entre 100 e 200!");
            }
            
            Console.ReadKey();
        }
    }
}
