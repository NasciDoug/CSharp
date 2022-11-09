using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário
            //deverá  informar 10 números inteiros e maiores que zero e armazená-los em um array.
            //O programa deverá exibir a média aritmética de todos os números ímpares do array.

            int[] num = new int[10];
            int soma=0, media, cont=0;


            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: ");

            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n______________________________________");
            Console.WriteLine("\nNúmeros impares digitados: \n");

            for (int i = 0; i<num.Length; i++)
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine(num[i]);
                    soma = soma + num[i];
                    cont++;
                }

            media = soma / cont;

            Console.WriteLine("\n______________________________________");
            Console.WriteLine("\nA média aritmética dos números impares digitados é igua a " + media);

            Console.ReadKey();

        }
    }
}
