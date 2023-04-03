using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeProvaReal
{
    public class Produto
    {
        public string nome;
        public string marca;
        public double preco;
        public double peso;

        public Produto(string nome, string marca, double preco, double peso)
        {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
            this.peso = peso;
        }
    }
}
