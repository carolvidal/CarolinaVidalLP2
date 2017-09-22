using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int x = 0, y = 0;
            double valor;
            while (x != 4)
            {
                Console.WriteLine("1- Converter massas\n2- Converter temperaturas\n3- Converter distâncias\n4- Sair");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("1- Quilos em Gramas\n2- Quilos em Toneladas");
                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (y == 1)
                    {
                        Converter.KgParaG(valor);
                    }

                    else if (y == 2)
                    {
                        Converter.KgParaT(valor);
                    }

                    else
                        throw new System.InvalidOperationException("Operação inválida!");
                }

                else if (x == 2)
                {
                    Console.WriteLine("1- Celsius em Fahrenheit\n2- Celsius em Kelvin");
                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (y == 1)
                    {
                        Converter.CParaFh(valor);
                    }

                    else if (y == 2)
                    {
                        Converter.CParaK(valor);
                    }
                    else
                        throw new System.InvalidOperationException("Operação inválida!");
                }

                else if (x == 3)
                {
                    Console.WriteLine("1- Metros em Quilômetros\n2- Quilômetros em Milhas");
                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o valor:");
                    valor = int.Parse(Console.ReadLine());

                    if (y == 1)
                    {
                        Converter.MParaKm(valor);
                    }

                    else if (y == 2)
                    {
                        Converter.KmParaMil(valor);
                    }
                    else
                        throw new System.InvalidOperationException("Operação inválida!");
                }

                else if (x == 4)

                    break;

                else

                    throw new System.InvalidOperationException("Operação inválida!");

            }

        }
    }
}
