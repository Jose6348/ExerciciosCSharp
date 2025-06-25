namespace Exercicios.Main.Exercicio12
{
    public class Produtos
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal PrecoProduto { get; set; }

        public Produtos(string nome, string categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            PrecoProduto = preco;
        }
    }
    
}
