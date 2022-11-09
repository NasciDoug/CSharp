using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite o nome do aluno: ");
            name = Console.ReadLine();
            
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
        
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("O aluno {0} obteve média {1}, portanto está APROVADO!", name, media);
            }
            else
            {
                Console.WriteLine("O aluno {0} obteve média {1}, portanto está REPROVADO!");
            }

            Console.ReadKey();
        }
    }
}
