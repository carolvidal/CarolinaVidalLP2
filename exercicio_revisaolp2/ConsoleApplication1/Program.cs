using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        struct Carro
        {
            public string modelo;
            public int pot;
            public double km;
        }

        static void Main(string[] args)
        {
            string final;
            int carros;
            Carro Carro1;
            Console.WriteLine("Insira o número de carros");
            carros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < carros; i++)
            {
                Console.WriteLine("Insira o seu modelo");
                Carro1.modelo = Console.ReadLine();
                Console.WriteLine("Insira a quilometragem: ");
                Carro1.km = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira a potência: ");
                Carro1.pot = Convert.ToInt32(Console.ReadLine());

                final = Sub(Carro1.modelo, Carro1.km, Carro1.pot);

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


