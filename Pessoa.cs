using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeProvaReal
{
    public class Pessoa
    {
        string nome;
        string cpf;
        double dinheiro;
        Carrinho Carrinho;

        public Pessoa(string nome, string cpf, double dinheiro, Carrinho carrinho)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dinheiro = dinheiro;
            this.Carrinho = carrinho;
        }

        public void AdicionarProduto(Produto produto)
        {
            if((produto.peso + Carrinho.pesoAtual) < Carrinho.pesoMax)
            {
                Console.WriteLine($"{produto.nome} foi adiocionado ao carrinho");
                Carrinho.produtos.Add(produto);
                Carrinho.pesoAtual += produto.peso;
            }
            else
            {
                Console.WriteLine("erro, peso maximo atingido");
            }
        }

        public void RemoverProduto(Produto produto)
        {
            Console.WriteLine($"{produto.nome} foi removido ao carrinho");
            Carrinho.produtos.Remove(produto);
        }

        public void ListarProdutos()
        {
            Console.WriteLine("\nProdutos no carrinho:");
            foreach(Produto p in Carrinho.produtos)
            {
                Console.WriteLine($"{p.nome} - {p.marca}");
            }
            Console.WriteLine("\n");
        }
    }
}
