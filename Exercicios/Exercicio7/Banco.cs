namespace Exercicios.Exercicio7
{
    public class Banco
    {
        public string Nome { get; set; }
        private List<Conta> contas = new();

        public Banco(string nome)
        {
            Nome = nome;
        }

        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }

        public Conta BuscarConta(int numero) {
            return contas.Find(c => c.Numero == numero);
        }
    }
}
