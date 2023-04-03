namespace testeProvaReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrinho c1 = new Carrinho(100);
            Pessoa gu = new Pessoa("Gustavo", "5231", 1000, c1);

            Alimento feijao = new Alimento(30, "Feijao", "Camil", 10, 5);
            Eletronico celular = new Eletronico(365, "Galaxy A9", "Samsung", 900, 1);
            Eletronico monitor = new Eletronico(730, "Monitor", "LG", 400, 5);
            Alimento vaca = new Alimento(3000, "Vaca", "Deus", 100, 48);

            gu.AdicionarProduto(monitor);
            gu.AdicionarProduto(feijao);
            gu.AdicionarProduto(celular);
            gu.AdicionarProduto(vaca);
            gu.AdicionarProduto(vaca);

            gu.ListarProdutos();

            gu.RemoverProduto(celular);

            gu.ListarProdutos();

        }
    }
}