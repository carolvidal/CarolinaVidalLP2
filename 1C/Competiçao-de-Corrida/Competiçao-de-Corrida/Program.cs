using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competiçao_de_Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            Competidor c = new Competidor();
            int n;

            Console.WriteLine("Número de competidores");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] tempoOficial = new double[n];
            double[] t1 = new double[n];
            double[] t2 = new double[n];
            double[] t3 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome:");
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tempo 1:");
                c.t1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tempo 2:");
                c.t2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tempo 3:");
                c.t3 = double.Parse(Console.ReadLine());

                tempoOficial[i] = c.TempoOficial();

                if (tempoOficial[i] < tempoOficial[i - 1])
                    Console.WriteLine(nome[i]);
                else
                    break;
            }
        }
    }
}
