using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while(num<=10)
            {
                Console.WriteLine("Número " + num);
                num++;
            }

            Console.ReadKey();
        }
    }
}
