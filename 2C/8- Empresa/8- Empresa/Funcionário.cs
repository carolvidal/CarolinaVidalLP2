using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Empresa
{
    abstract class Funcionário
    {
        public int numeroRegistro { get; set; }
        public string nome { get; set; }
        protected string cpf;

        public string Cpf
        {
            get
            {
                return cpf;
            }

            private set
            {
                if (value.Length == 11)
                    cpf = value;
            }
        }

        protected string email { get; set; }
        protected double salario { get; }

        public Funcionário(string n, string c, int nr)
        {
            nome = n;
            numeroRegistro = nr;
        }
    }
}
