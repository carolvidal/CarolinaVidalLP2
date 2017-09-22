using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            int soma = 0;

            Console.WriteLine("Insira o texto:");
            letra = Console.ReadLine();

            for (int i = 0; i < letra.Length; i++)
            {
                if (letra[i] == 'a' || letra[i] == 'A')
                    soma = soma + 1;
                else if (letra[i] == 'e' || letra[i] == 'E')
                    soma = soma + 1;
                else if (letra[i] == 'i' || letra[i] == 'I')
                    soma = soma + 1;
                else if (letra[i] == 'o' || letra[i] == 'O')
                    soma = soma + 1;
                else if (letra[i] == 'u' || letra[i] == 'U')
                    soma = soma + 1;
            }

            Console.WriteLine(" O número de vogais é :{0}", soma);
        }
    }
}
