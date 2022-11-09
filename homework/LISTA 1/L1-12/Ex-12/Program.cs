using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double nota1, nota2, nota3, media;

            Console.Write("Digite o nome do Aluno: ");
            name = Console.ReadLine();

            Console.Write("Digite a primeira nota do aluno {0}: ", name);
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno {0}: ", name);
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno {0}: ", name);
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno {0} é {1}!", name, media);

            Console.ReadKey();
        }
    }
}
