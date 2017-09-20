using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ConverterTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            TC t = new TC();
            int x = 1;

            while (x != 0)
            {
                Console.WriteLine("1 - Nova temperatura");
                Console.WriteLine("2 - Para Fahrenheit");
                Console.WriteLine("3 - Para Kelvin");
                Console.WriteLine("0 - Sair");
                x = int.Parse(Console.ReadLine());

                if (x != 0)
                {
                    Console.WriteLine("Temperatura:");
                    t.valor = double.Parse(Console.ReadLine());

                    if (x == 2)
                        Console.WriteLine(t.EmFahrenheit());
                    else if (x == 3)
                        Console.WriteLine(t.EmKelvin());
                }

                else
                    break;


            }
        }
    }
}
