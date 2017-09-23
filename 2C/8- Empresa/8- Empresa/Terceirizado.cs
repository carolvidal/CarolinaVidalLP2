using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Empresa
{
    class Terceirizado : Funcionário
    {
        public string empresaMatriz { get; set; }

        public Terceirizado(string n, string c, int nr, string emp) : base(n, c, nr)
        {
            empresaMatriz = emp;
        }
    }
}
