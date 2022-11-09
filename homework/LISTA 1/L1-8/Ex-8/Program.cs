using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Digite o nome do jogador: ");
            name = Console.ReadLine();

            Console.Write("Digite a idade do jogador: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: {0}", name);
            Console.WriteLine("Idade: {0}", age);

            if (age <= 13)
            {
                Console.WriteLine("Categoria: Infantil");
            }
            else 
            {
                if (age > 13 && age <= 17)
                {
                    Console.WriteLine("Categoria: Juvenil");
                }
                else
                {
                    Console.WriteLine("Categoria: Sênior");
                }
            }
            
            Console.ReadKey();

        }
    }
}
