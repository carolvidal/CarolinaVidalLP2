using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, final;
            int pot, carros;
            double km;
            Console.WriteLine("Insira o número de carros");
            carros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine("Insira o seu modelo");
                modelo = Console.ReadLine();
                Console.WriteLine("Insira a quilometragem: ");
                km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira a potência: ");
                pot = Convert.ToInt32(Console.ReadLine());

                final = Sub(modelo, km, pot);

                Console.WriteLine(final);

            }
        }

            static string Sub(string modelo, double km, int pot)
            {
                string modsaida, potsaida, final;

                if (km <= 5000)
                {
                    modsaida = "Novo";
                }
                else if (km>5000 && km <= 30000)
                {
                 modsaida = "Seminovo";
                }
                else
                {
                    modsaida = "Velho";
                }
                if (pot > 200)
                {
                    potsaida = "Potente";
                }
                else if (pot >= 120 && pot <= 200)
                {
                    potsaida = "Forte";
                }
                else
                    potsaida = "Popular";
                   
                final = String.Format("{0} - {1} - {2}", modelo, modsaida, potsaida);

                return final;
            }
        
        }

    }


