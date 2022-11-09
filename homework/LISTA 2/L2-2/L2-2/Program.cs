using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário
            //deverá  informar 10 números inteiros e maiores que zero e armazená-los em um array.
            //O programa deverá exibir a soma de todos os números pares do array.

            int[] num = new int[10];
            int soma = 0;

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: \n");

            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n_____________________________________");
            Console.WriteLine("\nNúmeros pares digitados: \n");

            for (int i = 0; i < num.Length; i++)
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                    soma = soma + num[i];
                }

            Console.WriteLine("\n_____________________________________");
            Console.WriteLine("\nA soma dos números pares digitados é igua a " + soma);

            Console.ReadKey();
        }
    }
}
