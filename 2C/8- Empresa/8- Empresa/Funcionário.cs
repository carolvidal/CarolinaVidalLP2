using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Empresa
{
    abstract class Funcionário
    {
        protected int numR { get; private set; }
        protected string nome { get; set; }
        protected string cpf
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

        protected string email { get; set; }
        protected double salario { get; }

    }
}
