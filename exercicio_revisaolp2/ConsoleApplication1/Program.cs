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
            string modelo, modsaida,potsaida;
            int km,pot,carros;
            Console.WriteLine("Insira o numero de carros");
            carros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < carros; i++ ){
             Console.WriteLine("insira o seu modelo ");
             modelo= Console.ReadLine();
             Console.WriteLine(" Insira a quilometragem :");
             km = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Insira a potência :");
             pot = Convert.ToInt32(Console.ReadLine());

             
             if (km <= 5000)
             {
                 modsaida = "novo";
             }
             else if (km>5000 && km<=30000)
             {
                 modsaida = "seminovo";
             }
             else
             {
                 modsaida = "velho";
             }

             if (pot > 200)
             {
                 potsaida = "potente";
             }
             else if (pot >= 120 && pot <= 200)
             {
                 potsaida = "forte";
             }
             else
                 potsaida = "popular";


             Console.WriteLine("{0} - {1} - {2}", modelo, modsaida, potsaida);
            }
        }
    }
}
