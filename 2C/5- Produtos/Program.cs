using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do produto:");

            Console.WriteLine("Informe o ID: ");
            string id = Console.ReadLine();

            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o preço: ");
            double preço = double.Parse(Console.ReadLine());

            Produto p = new Produto (id, nome, preço);

            int x = 4;

            while (x != 0)
            {
                Console.WriteLine(" 1- Reposição de estoque\n 2- Retirada de estoque\n 3- Informações do produto\n 0- Sair");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("Valor a ser reposto:");
                    p.Repor(int.Parse(Console.ReadLine()));
                }

                else if (x == 2)
                {
                    Console.WriteLine("Valor a ser retirado:");
                    p.Retirar(int.Parse(Console.ReadLine()));
                }

                else if (x == 3)
                {
                    p.Imprimir();
                }

                else if (x == 0)
                {
                    break;
                }

                else
                    throw new System.InvalidOperationException("Comando inválido!");
            }
        }
    }
}
