using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa com a Linguagem C# para ler a nota da prova de 15 alunos,
            //armazenando - em um vetor. Calcule e imprima média geral dos alunos.

            double [] nota = new double[5];
            double soma = 0, media, cont=0;

            Console.WriteLine("....:::: Início do Programa ::::...");

            for (double i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("\nDigite a nota do aluno: ");
                nota[(int)i] = double.Parse(Console.ReadLine());
                soma = soma + nota[(int)i];
                Console.WriteLine("\n__________________________");
                cont++;
            }

            media = soma / cont;

            Console.WriteLine("\nA média geral dos alunos é " + media);

            Console.ReadKey();



        }
    }
}
