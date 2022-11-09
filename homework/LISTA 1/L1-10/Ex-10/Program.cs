using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, media;

            Console.Write("Digite o valor do primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do terceiro número: ");
            num3 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3) / 3;

            Console.WriteLine("A média aritmética de {0} - {1} - {2} é: {3}", num1, num2, num3, media);

            Console.ReadKey();
        }
    }
}
