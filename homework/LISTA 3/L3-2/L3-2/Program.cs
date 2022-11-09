using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numa danceteria, numa noite, estiveram 150 clientes, desses, muitos pagaram suas contas com cheque,
            //cartão de credito e cédulas. Construa programa com a Linguagem C# para somar o total de valores pagos em cédulas,
            //cheques e cartões de credito, e a receita total que obteve a danceteria.

            int [] cliente = new int[150];
            int [] card = new int [150];
            int [] money = new int [150];
            int [] cheque = new int [150];
            int metodo, totalCard = 0, totalMoney = 0, totalCheque = 0, receita;
           

            Console.WriteLine(".....::::: Início do Programa :::::.....");
            
            for (int i = 0; i < cliente.Length; i++)
            {
                Console.WriteLine("\nQual a forma de pagamento?\n\n Digite 1 - Cartão\n Digite 2 - Cédula/Espécie\n Digite 3 - Cheque\n");
                metodo = int.Parse(Console.ReadLine());

                if (metodo == 1)
                {
                    Console.WriteLine("\nDigite o valor a pagar: ");
                    card[i] = int.Parse(Console.ReadLine());
                    totalCard = totalCard + card[i];
                }
                else if (metodo == 2)
                {
                    Console.WriteLine("Digite o valor a pagar: ");
                    money[i] = int.Parse(Console.ReadLine());
                    totalMoney = totalMoney + money[i];
                }
                else
                {
                    Console.WriteLine("Digite o valor a pagar: ");
                    cheque[i] = int.Parse(Console.ReadLine());
                    totalCheque = totalCheque + cheque[i];
                }
            }
            Console.WriteLine("\n_____________________________________________________________________");
            Console.WriteLine("\nO total de pagamentos efetuados através de cartão é: {0}", totalCard);
            Console.WriteLine("\nO total de pagamentos efetuados em dinheiro é: {0}", totalMoney);
            Console.WriteLine("\nO total de pagamentos efetuados em cheque é: {0}", totalCheque);

            receita = totalCard + totalCheque + totalMoney;

            Console.WriteLine("\n_____________________________________________________________________");

            Console.WriteLine("\nReceita total: {0}", receita);

            Console.ReadKey();
            
        }
    }
}
