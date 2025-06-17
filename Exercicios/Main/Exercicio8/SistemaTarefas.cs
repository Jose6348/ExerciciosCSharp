using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios.Main.Exercicio8
{
    /// <summary>
    /// Representa uma única tarefa.
    /// </summary>
    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; }
        public bool Concluida { get; set; }

        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Concluida = false;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}\nDescrição: {Descricao}\nData de Criação: {DataCriacao.ToShortDateString()}\nConcluída: {(Concluida ? "Sim" : "Não")}\n";
        }
    }

    public class SistemaTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        /// <summary>
        /// Adiciona uma nova tarefa à lista.
        /// </summary>
        /// <param name="titulo">O título da tarefa.</param>
        /// <param name="descricao">A descrição da tarefa.</param>
        public void AdicionarTarefa(string titulo, string descricao)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("O título da tarefa não pode ser vazio.");
                return;
            }
            tarefas.Add(new Tarefa(titulo, descricao));
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        /// <summary>
        /// Lista todas as tarefas cadastradas.
        /// </summary>
        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            Console.WriteLine("--- Lista de Tarefas ---");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

        /// <summary>
        /// Marca uma tarefa como concluída com base no título.
        /// </summary>
        /// <param name="titulo">O título da tarefa a ser marcada como concluída.</param>
        public void MarcarComoConcluida(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("O título da tarefa não pode ser vazio.");
                return;
            }

            var tarefa = tarefas.FirstOrDefault(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine($"A tarefa \"{titulo}\" foi marcada como concluída.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o título \"{titulo}\" não encontrada.");
            }
        }
    }
}