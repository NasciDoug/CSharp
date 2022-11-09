using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A=10, B=20, C=30, D=2,R;

            A += 10;
            B -= 12;
            C /= 2;
            D *= 2;

            R = ++A + ++B + ++C + ++D;

            Console.WriteLine(R);

            Console.ReadKey();
        }
    }
}
