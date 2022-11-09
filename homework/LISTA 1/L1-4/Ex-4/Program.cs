using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            double nota1, nota2, nota3, media;

            Console.Write("Digite o nome do aluno: ");
            aluno = Console.ReadLine();

            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 * 2 + nota2 * 4 + nota3 * 6) / 12;

            Console.WriteLine("Aluno: {0}", aluno);
            Console.WriteLine("Média Final: {0}", media);

            Console.ReadKey();
        }
    }
}
