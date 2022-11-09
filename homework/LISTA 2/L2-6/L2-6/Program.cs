using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um programa com a Linguagem C# no qual o usuário deverá  informar 10 números inteiros e
            //maiores que zero e armazená-los em um array.Em seguida o usuário deverá informar mais 10 valores
            //numéricos inteiros e maiores que zero e armazená - los em outro array.
            //O programa deverá exibir todos os valores que não fazem parte(não estão presentes) nos dois arrays.

            int [] num1 = new int [10];
            int [] num2 = new int [10];
            

            Console.WriteLine("......::::::: Início do Programa ::::::.....");
            Console.WriteLine("\nDigite 10 números inteiros maiores que 0: \n");
            
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite mais 10 números inteiros maiores que 0: \n");

            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n.............................\n");


            Console.ReadKey();
            
        }
    }
}
