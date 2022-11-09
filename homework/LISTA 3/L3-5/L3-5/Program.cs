using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# para ler um conjunto de números reais, armazenando - os em um array.O programa deverá calcular o
            //quadrado dos valores deste array, armazenando os resultados em outro array.Os conjuntos têm 10 elementos cada. Imprimir todos os conjuntos(arrays).

            double[] num = new double[4];
            double[] quad = new double[4];


            Console.WriteLine(".....:::: Início do Programa ::::....");
            Console.WriteLine("\nDigite 10 números reais: ");

            for (double i = 0; i < num.Length; i++)
                num[(int)i] = double.Parse(Console.ReadLine());

            Console.WriteLine("\n_____________________________");
            Console.WriteLine("\nNúmeros digitados: ");

            for (double i = 0; i < num.Length; i++)
                Console.WriteLine("         "+num[(int)i]);

            Console.WriteLine("\n_____________________________");
            Console.WriteLine("\nNúmeros digitados elevado a potência 2: ");

            for (double i = 0; i < num.Length; i++)
            {
                for (double j = 0; j < quad.Length; j++)
                {
                    quad[(int)j] = num[(int)i] * num[(int)i];
                    Console.WriteLine("         " + quad[(int)j]);
                }  
            }

            Console.ReadKey();

        }
    }
}
