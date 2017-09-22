using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Produtos
{
    class Produto
    {
        public string id { get; private set; }
        public string nome { get; private set; }
        public int QtdEstoque { get; private set; }
        public double preço { get; set; }
        public string marca { get; }

        public Produto (string i, string n, double p) {

        id = i;
        nome = n;
        preço = p;
        QtdEstoque = 0;

        }

        public void Repor (int NovaQtd) {

        QtdEstoque += NovaQtd;

        }

        public void Retirar (int valor) {

            if (QtdEstoque - valor > QtdEstoque)
                throw new System.InvalidOperationException("Operação inválida!");
            else
                QtdEstoque -= valor;
        }

        public void Imprimir() {

        Console.WriteLine("Produto: {0} - R${1:0.00} - Estoque: {2}", nome, preço, QtdEstoque);

        }

        

    }
}
