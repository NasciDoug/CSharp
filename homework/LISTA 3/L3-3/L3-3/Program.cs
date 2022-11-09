using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Em uma eleição presidencial, existem dois candidatos. Os votos são informados através de código.Os dados utilizados obedecem à seguinte codificação:

            //1 e 2 = voto para os respectivos candidatos;
            //3 = voto em branco;
            //4 = voto nulo.

            //Escreva um programa com a Linguagem C# que calcule e escreva na tela:

            int[] população = new int [10];
            
            int choose, contCandi1=0, contCandi2=0, contBranco=0, contNulo=0, soma;

            Console.WriteLine("......:::::: Início do Programa ::::::.......");
            
            for (int i = 0; i<população.Length; i++)
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("\nDigite o número referente ao seu candidato:\n\n1 - Candidato1\n2 - Candidato2\n3 - Branco\n");
                choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    contCandi1++;
                    Console.WriteLine("\nSeu voto foi contabilizado para o Candidato1.");
                }

                else if (choose == 2)
                {
                    contCandi2++;
                    Console.WriteLine("\nSeu voto foi contabilizado para o Candidato1.");
                }

                else if (choose == 3)
                {
                    contBranco++;
                    Console.WriteLine("\nSeu voto foi inválidado.");
                }
                else
                {
                    contNulo++;
                    Console.WriteLine("\nSeu voto foi inválidado.");
                }
            }

            soma = contNulo + contCandi2 + contCandi1 + contBranco;

            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("\n......:::::: Resultado Final ::::::......");

            Console.WriteLine("\nTotal de votos = " + soma);
            Console.WriteLine("\nCandidato1 = " + contCandi1);
            Console.WriteLine("\nCandidato2 = " + contCandi2);
            Console.WriteLine("\nVotos em Branco = " + contBranco);
            Console.WriteLine("\nVotos Nulo = " + contNulo);

            if (contCandi1 > contCandi2)
                Console.WriteLine("\n\n***O candidato vencedor é o Candidato1***");
            else
                Console.WriteLine("\n\n***O candidato vencedor é o Candidato2***");

            Console.ReadLine();

        }
    }
}
