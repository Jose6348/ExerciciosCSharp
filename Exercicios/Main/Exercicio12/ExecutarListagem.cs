using System.Collections.Generic;
using System.Linq;

namespace Exercicios.Main.Exercicio12
{

    public class ExecutarListagem
    {
        public List<Produtos> Produtos { get; private set; }

        public ExecutarListagem()
        {
            Produtos = new List<Produtos>
            {
                // Eletrônicos
                new Produtos("Smartphone", "Eletrônicos", 1500.00m),
                new Produtos("Fone de Ouvido", "Eletrônicos", 80.00m),
                new Produtos("Notebook", "Eletrônicos", 3500.00m),

                // Limpeza
                new Produtos("Detergente", "Limpeza", 5.50m),
                new Produtos("Desinfetante", "Limpeza", 12.00m),
                new Produtos("Esponja", "Limpeza", 3.00m),

                // Alimentos
                new Produtos("Arroz", "Alimentos", 25.00m),
                new Produtos("Carne", "Alimentos", 120.00m),
                new Produtos("Leite", "Alimentos", 7.50m)
            };
        }

        public void FiltrarEExibirProdutosCaros()
        {
            Console.WriteLine("-----Produtos com preço acima de R$100---");

            var produtosCaros = Produtos.Where(produto => produto.PrecoProduto > 100);

            foreach (var produto in produtosCaros)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.PrecoProduto}");
            }
        }
    }
}
