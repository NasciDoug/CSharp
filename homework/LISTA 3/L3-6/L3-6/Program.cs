using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa com a Linguagem C# que leia um array de 8
            //posições e, em seguida, leia também dois valores X e Y quaisquer
            //correspondentes à primeira e última posição do array.Ao final seu programa
            //deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.

            double[] num = new double[8];
            double num1=0, num2=0, soma=0;

            Console.WriteLine("....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 8 números: ");

            for (int i = 0; i < num.Length; i++)
                num[(int)i] = double.Parse(Console.ReadLine());

            for (double i = 0; i < num.Length; i++)
            {
                num1 = num[(int)0];
                num2 = num[(int)7];
            }

            soma = num1 + num2;

            Console.WriteLine("\nA soma do primeiro e último número digitado é : " + soma);

            Console.ReadKey();




        }
    }
}
