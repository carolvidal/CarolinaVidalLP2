using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosDaHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pag1Hr, hrs1Dia, n, total1Hr = 0, totalDias, p = 0, i = 0;
            
            n = int.Parse(Console.ReadLine());
            pag1Hr = int.Parse(Console.ReadLine());
            hrs1Dia = int.Parse(Console.ReadLine());
            
            Livro[] livro = new Livro[n];
            
            while (i < n)
            {
                livro[i] = new Livro();
                
                livro[i].nome = Console.ReadLine();
                livro[i].pags = int.Parse(Console.ReadLine());
                livro[i].diasDev = int.Parse(Console.ReadLine());
                total1Hr = total1Hr + livro[i].TempoDeLeitura(pag1Hr);
                
                i++;
            }
            while (i < n)
            {
                if (livro[i].TempoDeLeitura(pag1Hr) > n * hrs1Dia)
                {
                    Console.WriteLine("{0} não pode ser lido", livro[i].nome);

                    p++;
                }

                i++;
            }
                if (p == 0)
                { 
                    Console.WriteLine("Todos os livros são possíveis de se ler");
                    totalDias = total1Hr / hrs1Dia;
                    Console.WriteLine("Levará {0} dias para ler os livros", totalDias);
                }
        }
    }
}
