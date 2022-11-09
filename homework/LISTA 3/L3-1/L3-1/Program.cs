using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados: 10 números digitados pelo usuário. Escreva um programa com a Linguagem C# para exibir os valores negativos e que calcule e exiba a média
            //dos valores menores que zero.

            int[] num = new int[10];
            int media;
            int soma = 0;
            int contador = 0;
            ;
            Console.WriteLine(".....::::: Início do Programa :::::.....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: \n");

            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n......::::: Números \"Negativados\" :::::.....\n");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = num[i] * -1;
                Console.WriteLine(num[i]);
            }


            for (int i = 0; i < num.Length; i++)
            {
                soma = soma + num[i];
                contador++;
            }

            media = soma / contador;

            Console.WriteLine("\nA média é igual a {0}", media);

            Console.ReadKey();
        }
    }
}
