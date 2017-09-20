using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__CódigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg = new Mensagem();
            int n = 1;
           
            while (n != 0)
            {
                Console.WriteLine("1 - Codificar\n2 - Decodificar\n0 - Sair");

                n = int.Parse(Console.ReadLine());


                if (n == 1)
                {
                    Console.WriteLine(msg.Codificar());
                }
                else if (n == 2)
                {
                    Console.WriteLine(msg.Decodificar());
                }
                else
                    break;
            }
        }
    }
}
