using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeProvaReal
{
    public class Carrinho
    {
        public double pesoMax;
        public List<Produto> produtos;
        public double pesoAtual;

        public Carrinho(double pesoMax)
        {
            this.pesoMax = pesoMax;
            produtos = new List<Produto>();
            pesoAtual = 0;
        }


    }
}
