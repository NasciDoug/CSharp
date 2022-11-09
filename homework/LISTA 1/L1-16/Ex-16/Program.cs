using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            if (a>b && b>c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                if(a>c && c>b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
                else
                {
                    if(b>a && a>c)
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                    }
                    else
                    {
                        if(b>c && c>a)
                        {
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            Console.WriteLine(a);
                        }
                        else
                        {
                            if(c>a && a>b)
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                            }
                            else
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(b);
                                Console.WriteLine(a);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
