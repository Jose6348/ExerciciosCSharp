namespace Exercicios.Main.Exerciico10
{
    public class Chamado
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; }
        public Prioridade Prioridade { get; set; }
        public bool Resolvido { get; set; }
        public Chamado(string titulo, string descricao, Prioridade prioridade)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Prioridade = prioridade;
            Resolvido = false;
        }
        public override string ToString()
        {
            return $"Título: {Titulo}\nDescrição: {Descricao}\nData de Criação: {DataCriacao.ToShortDateString()}\nPrioridade: {Prioridade}\nResolvido: {(Resolvido ? "Sim" : "Não")}\n";
        }
    }

    public enum Prioridade
    {
        Baixa,
        Media,
        Alta
    }
}
