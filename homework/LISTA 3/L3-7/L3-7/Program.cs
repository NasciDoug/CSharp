using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa com a Linguagem C# que leia 6 valores
            //inteiros e, em seguida, mostre na tela os valores lidos na ordem inversa.

            int[] num = new int[6];

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 6 números inteiros: ");

            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n_______________________________");
            Console.WriteLine("\nNOrdem inversa dos números digitados: \n");

            for (int i = 5; i >= 0; i--)
                Console.WriteLine(num[i]);

            Console.ReadKey();



        }
    }
}
