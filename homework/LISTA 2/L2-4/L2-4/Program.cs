using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário
            //deverá  informar 10 números inteiros e maiores que zero e armazená-los em um array.
            //O programa deverá exibir a média aritmética entre o maior e o menor valor do array.

            int[] num = new int[10];
            int maior, menor, soma, media;

            Console.WriteLine("....:::: Inínio do Programa ::::....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: \n");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            maior = num[0];
            menor = num[0];

            for (int i = 0; i<num.Length; i++)
            {
                if (num[i] > maior)
                    maior = num[i];
                else if (num[i] < menor)
                    menor = num[i];
            }

            soma = maior + menor;
            media = soma / 2;

            Console.WriteLine("\n_______________________________");
            Console.WriteLine("\nA média aritmética entre o maior e o menor número digitados é igual a " + media);

            Console.ReadKey();
        }
    }
}
