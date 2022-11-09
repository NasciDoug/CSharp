using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foi feita uma pesquisa
            //entre os 1000 habitantes de uma região para coletar os seguintes 
            //dados: sexo (0 - feminino, 1 - masculino), idade e altura.
            //Escreva um programa com a Linguagem C# que leia as informações
            //coletadas e mostre as seguintes informações na tela:

            //a)      média da idade do grupo;
            //b)      média da altura das mulheres;
            //c)      média da idade dos homens;
            //d)      percentual de pessoas com idade entre 18 e 35 anos
            //(inclusive).

            double[,] dadosPop = new double[1000, 3];
            double mulher = 0, homem = 0, idadeHomens=0, idadeMulheres=0,mediaIdade, alturaMulheres=0, MediaIdadeHomens, cont=0;
            double mediaAlturaMulher, percentual;

            Console.WriteLine("....:::: Início do Programa ::::....");
            
            for (double i = 0; i < 1000; i++)
            {
                Console.WriteLine("\n_______________________");
                Console.WriteLine("\nGenêro (escolha o número): \n   1 - Feminino\n   2 - Masculino");
                dadosPop[(int)i,0] = double.Parse(Console.ReadLine());

                if (dadosPop[(int)i, 0] == 1)
                {
                    mulher++;
                    
                    Console.WriteLine("\n_______________________");
                    Console.Write("\nDigite a idade: ");

                    dadosPop[(int)i, 1] = double.Parse(Console.ReadLine());

                    idadeMulheres = idadeMulheres + dadosPop[(int)i, 1];

                    if (dadosPop[(int)i, 1] > 18 && dadosPop[(int)i, 1] < 35)
                        cont++;

                    Console.WriteLine("\n_______________________");
                    Console.Write("\nDigite a altura: ");

                    dadosPop[(int)i, 2] = double.Parse(Console.ReadLine());
                    alturaMulheres = alturaMulheres + dadosPop[(int)i, 2];
                }
                else
                {
                    homem++;

                    Console.WriteLine("\n_______________________");
                    Console.Write("\nDigite a idade: ");

                    dadosPop[(int)i, 1] = double.Parse(Console.ReadLine());

                    idadeHomens = idadeHomens + dadosPop[(int)i, 1];

                    if (dadosPop[(int)i, 1] > 18 && dadosPop[(int)i, 1] < 35)
                        cont++;

                    Console.WriteLine("\n_______________________");
                    Console.Write("\nDigite a altura (cm): ");

                    dadosPop[(int)i, 2] = double.Parse(Console.ReadLine());

                }
            }

            for (double i = 0; i < 1000; i++)
            {
                if (dadosPop[(int)i, 0] == 1)
                    {
                        Console.WriteLine("mulher | {0} anos | {1}m", dadosPop[(int)i, 1], dadosPop[(int)i,2]);
                    }

                    else
                        Console.WriteLine("homem  | {0} anos | {1}m", dadosPop[(int)i, 1], dadosPop[(int)i,2]);  
            }

            mediaIdade = (idadeMulheres + idadeHomens) / (mulher + homem);

            mediaAlturaMulher = (alturaMulheres / mulher)/100;

            MediaIdadeHomens = idadeHomens / homem;

            percentual = (cont / (homem+mulher))*100;

            Console.WriteLine("\nMédia da idade do grupo é {0} anos", mediaIdade);
            Console.WriteLine("\nMédia da altura das mulheres é {0} m", mediaAlturaMulher);
            Console.WriteLine("\nMédia da idade dos homens é {0} anos", MediaIdadeHomens);
            Console.WriteLine("\nPercentual entre 18 e 35 anos é {0}%", percentual);

            Console.ReadKey();

        }
    }
}
