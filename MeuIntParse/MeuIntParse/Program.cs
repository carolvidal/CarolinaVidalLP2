using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuIntParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 * MeuIntParse(Console.ReadLine()));
        }
        public static int MeuIntParse(string numero)
        {
            int multiplicador = 1, soma = 0, i;

            for (i = numero.Length - 1; i >= 0; i--)
            {
                soma = soma + (numero[i] - '0') * multiplicador;
                multiplicador = multiplicador * 10;
            }
            return soma;

        }
    }
}
