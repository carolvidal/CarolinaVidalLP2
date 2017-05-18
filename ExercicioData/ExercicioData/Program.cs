using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioData
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, dia, mes, ano;

            Console.WriteLine("Insira a data:");
            data = Console.ReadLine();

            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);
            ano = data.Substring(6, 4);

            switch (mes)
            {
                case "01": { mes = "Janeiro"; break; }
                case "02": { mes = "Fevereiro"; break; }
                case "03": { mes = "Março"; break; }
                case "04": { mes = "Abril"; break; }
                case "05": { mes = "Maio"; break; }
                case "06": { mes = "Junho"; break; }
                case "07": { mes = "Julho"; break; }
                case "08": { mes = "Agosto"; break; }
                case "09": { mes = "Setembro"; break; }
                case "10": { mes = "Outubro"; break; }
                case "11": { mes = "Novembro"; break; }
                case "12": { mes = "Dezembro"; break; }
            }

            Console.WriteLine("{0} de {1} de {2}", dia, mes, ano);
            
        }
    }
}
