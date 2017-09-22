using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Empresa
{
    class Terceirizado
    {
        public int numR { get; private set; }
        public string nome { get; set; }
        public string cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                if (value.Length == 11)
                    cpf = value;
            }
        }
        public string email { get; set; }
        public double sal { get; private set; }

        private int dataEntrada { get; }

        public Terceirizado(string n, string c, int nr)
        {
            nome = n;
            cpf = c;
            numR = nr;
        }
    }
}
