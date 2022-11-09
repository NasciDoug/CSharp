using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double wage, commis, total, qtdVend;

            Console.WriteLine("Digite o nome do funcionário: ");
            name = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário: ");
            wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de vendas efetuadas pelo funcionário: ");
            qtdVend = double.Parse(Console.ReadLine());

            commis = (wage * qtdVend) * 0.20;

            total = wage + commis;

            Console.WriteLine("Funcionário: {0} ", name);
            Console.WriteLine("Salário: {0}", wage);
            Console.WriteLine("Salário + Comissão: {0}", total);

            Console.ReadKey();
        }
    }
}
