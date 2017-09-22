using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, mes;
            int dia, diaAno;

            data = Console.ReadLine();

            dia = int.Parse(data.Substring(0, 2));
            mes = data.Substring(6, 4);

            if (dia < 10)
                mes = data.Substring(5, 4);
            else
                mes = data.Substring(6, 4);

            if (mes == "Feve" || mes == "feve")
                diaAno = dia + 31;
            else if (mes == "Març" || mes == "març")
                diaAno = dia + 31 + 28;
            else if (mes == "Abri" || mes == "abri")
                diaAno = dia + 31 + 28 + 31;
            else if (mes == "Maio" || mes == "maio")
                diaAno = dia + 31 + 28 + 31 + 30;
            else if (mes == "Junh" || mes == "junh")
                diaAno = dia + 31 + 28 + 31 + 30 + 31;
            else if (mes == "Julh" || mes == "julh")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30;
            else if (mes == "Agos" || mes == "agos")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31;
            else if (mes == "Sete" || mes == "sete")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
            else if (mes == "Outu" || mes == "outu")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
            else if (mes == "Nove" || mes == "nove")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
            else if (mes == "Deze" || mes == "deze")
                diaAno = dia + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
            else
                diaAno = dia;

            Console.WriteLine("{0}° dia do ano", diaAno);
        }
    }
}
