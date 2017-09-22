using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Conversor
{
    class Converter
    {
        public static void KgParaG(double k)
        {
            Console.WriteLine("{0} g", k * 1000);
        }
        public static void KgParaT(double k)
        {
            Console.WriteLine("{0} t", k / 1000);
        }
        public static void CParaFh(double c)
        {
            Console.WriteLine("{0} F°", (c * 0.55) + 32);
        }
        public static void CParaK(double c)
        {
            Console.WriteLine("{0} K", c + 273);
        }
        public static void FhParaC(double f)
        {
            Console.WriteLine("{0} C°", (f - 32) * 0.55);
        }

        public static void MParaKm(double m)
        {
            Console.WriteLine("{0} km", m * 1000);
        }

        public static void KmParaMil(double km)
        {
            Console.WriteLine("{0} mi", km * 0.621);
        }

    }
}
