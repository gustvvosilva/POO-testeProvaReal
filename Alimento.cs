using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeProvaReal
{
    public class Alimento : Produto
    {
        int diasValidade;

        public Alimento(int diasValidade, string nome, string marca, double preco, double peso) : base(nome, marca, preco, peso)
        {
            this.diasValidade = diasValidade;
        }
    }
}
