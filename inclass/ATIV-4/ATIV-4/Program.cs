using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIV_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double nota1, nota2, nota3, nota4, media;
            int falta;

            Console.Write("Digite o nome do aluno: ");
            name = Console.ReadLine();

            Console.Write("Digite a primeira nota do aluno {0}: ", name);
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno {0}: ", name);
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno {0}: ", name);
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno {0}: ", name);
            nota4 = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de faltas do aluno {0}: ", name);
            falta = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4)/4;

            if(falta > 20)
            {
                Console.WriteLine("O (A) aluno (a) {0}, obteve média {1}, mas ultrapassou o limite de faltas, tendo obtido {2} faltas durante o ano letivo, por isso, está REPROVADO.", name, media, falta);
            }
            else
            {
                Console.WriteLine("O (A) aluno (a) {0} está APROVADO com média {1} e {2} faltas durante o ano letivo, ", name, media, falta);
            }

            Console.ReadKey();
        }
    }
}
