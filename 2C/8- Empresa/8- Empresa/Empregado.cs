using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Empresa
{
    class Empregado : Funcionário
    {
        public int dataEntrada { get; set; }

        public Empregado(string n, string c, int nr) : base(n, c, nr) { }

    }
}
