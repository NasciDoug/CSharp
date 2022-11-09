using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário deverá  informar 10 números inteiros 
            //e maiores que zero e armazená-los em um array.
            //Exibir na console primeiramente os valores pares armazenados no array e em seguida os valores ímpares.

            int[] num = new int[10];

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que zero: ");

            for (int i=0; i<num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n________________________________");
            Console.WriteLine("\nNúmeros pares digitados: \n");

            for (int i=0; i<num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    Console.WriteLine(num[i]);
            }

            Console.WriteLine("\n________________________________");
            Console.WriteLine("\nNúmeros impares digitados: \n");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                    Console.WriteLine(num[i]);
            }

            Console.ReadKey();

        }
    }
}
