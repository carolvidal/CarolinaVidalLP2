using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        public struct Carro
        {
            public string modelo;
            public int pot;
            public double km;
            public string placa;
            public string cor;
            public string fabricante;
            public int ano;
        }

        static void Main(string[] args)
        {

            int carros = int.Parse(Console.ReadLine());

            Carro[] Carros = new Carro[carros];

            for (int i = 0; i < carros; i++)
            {
                Carros[i].modelo = Console.ReadLine();
                Carros[i].km = Double.Parse(Console.ReadLine());
                Carros[i].pot = Int32.Parse(Console.ReadLine());
                Carros[i].placa = Console.ReadLine();
                Carros[i].cor = (Console.ReadLine());
                Carros[i].fabricante = (Console.ReadLine());
                Carros[i].ano = Int32.Parse(Console.ReadLine());

            }

            for (int i = 0; i < carros; i++)
                Console.WriteLine(Classificar(Carros[i]));
        }

        public static string Classificar(Carro c)
        {
            string modsaida, potsaida;

            if (c.km <= 5000)
            {
                modsaida = "Novo";
            }
            else if (c.km > 5000 && c.km <= 30000)
            {
                modsaida = "Seminovo";
            }
            else
            {
                modsaida = "Velho";
            }

            if (c.pot > 200)
            {
                potsaida = "Potente";
            }
            else if (c.pot >= 120 && c.pot <= 200)
            {
                potsaida = "Forte";
            }
            else
                potsaida = "Popular";

            return String.Format("{0} - {1} - {2}", c.modelo, modsaida, potsaida);

        }

        public static void AterarModelo(Carro c)
        {
            c.km = Double.Parse(Console.ReadLine());
        }

        public static void AterarCor(Carro c)
        {
            c.cor = Console.ReadLine();
        }

        public static int CalcularTaxaDeUso(Carro c)
        {
            int anoAtual, modsaida;

            anoAtual = Int32.Parse(Console.ReadLine());
            modsaida = anoAtual - c.ano;
            return modsaida;

        }
    }

}


