using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# para ler um array de 10
            //posições e atribur valor 0 para todos os elementos que possuírem valores
            //negativos.

            double[] num = new double[10];

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números: ");

            for (int i = 0; i < num.Length; i++)
            {
                num[(int)i] = double.Parse(Console.ReadLine());
                if(num[(int)i] < 0)
                    num[(int)i] = 0;
            }

            Console.WriteLine("\n__________________________________________________");
            Console.WriteLine("\nSubstituição dos números negativos digitados por 0: ");

            for (int i = 0; i < num.Length; i++)
                Console.WriteLine(num[(int)i]);

            Console.ReadKey();            
            
        }
    }
}
