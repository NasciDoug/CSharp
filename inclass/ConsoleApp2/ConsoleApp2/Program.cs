using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Insira a idade do jogador: ");
            idade = int.Parse(Console.ReadLine());

            if(idade <= 13)
            {
                Console.WriteLine("Infantil");
            }

            else if (idade >13 && idade <=17)
            {
                Console.WriteLine("Juvenil");
            }
            else
            {
                Console.WriteLine("Adulto");
            }

            Console.ReadKey();
        }
    }
}
