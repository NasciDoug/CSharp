using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# que leia um array de 10 posições e verifique se existem valores iguais e os escreva na tela.

            double[] num = { 2, 5, 8, 10, 2, 23, 2, 4, 5, 8, 8 };
            
            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nOs números abaixo se repetem na array: \n");
            
            for (double i = 0; i < num.Length; i++)
            {
                for (double j = 0; j< num.Length; j++)
                {
                   if (num[(int)j] == num[(int)i])
                        Console.WriteLine(num[(int)i]);
                }
            }

            Console.ReadKey();

        }
    }
}
