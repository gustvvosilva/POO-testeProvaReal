using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeProvaReal
{
    public class Eletronico : Produto
    {
        int diasGarantia;

        public Eletronico(int diasGarantia, string nome, string marca, double preco, double peso) : base(nome, marca, preco, peso)
        {
            this.diasGarantia = diasGarantia;
        }
    }
}
