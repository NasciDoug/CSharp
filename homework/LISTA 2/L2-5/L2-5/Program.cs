using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário deverá  informar 10 números inteiros e 
            //maiores que zero e armazená-los em um array.
            //Em seguida o usuário deverá informar mais 10 valores numéricos inteiros e maiores que zero e armazená - los
            //em outro array.O programa deverá exibir todos os valores que fazem parte(estão presentes) nos dois arrays.

            int[] num1 = new int[10];
            int[] num2 = new int[10];

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: \n");

            for (int i = 0; i < num1.Length; i++)
                num1[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n______________________________________________");
            Console.WriteLine("\nDigite mais 10 números inteiros maiores que 0: \n");

            for (int j = 0; j < num2.Length; j++)
                num2[j] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n______________________________________________");
            Console.WriteLine("\nO números abaixo estão presentes nas duas arrays: \n");

            for (int i=0; i<num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == num2[j])
                        Console.WriteLine(num1[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
