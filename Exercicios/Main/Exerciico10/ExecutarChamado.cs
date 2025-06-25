using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios.Main.Exerciico10
{
   
    public class ExecutarChamado
    {
        private List<Chamado> _chamados = new List<Chamado>();

        public void Iniciar()
        {
            string opcao;
            do
            {
                Console.WriteLine("\n--- Sistema de Gerenciamento de Chamados ---");
                Console.WriteLine("1. Abrir Novo Chamado");
                Console.WriteLine("2. Listar Chamados Abertos");
                Console.WriteLine("3. Listar Todos os Chamados");
                Console.WriteLine("4. Marcar Chamado como Resolvido");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AbrirNovoChamado();
                        break;
                    case "2":
                        ListarChamados(chamados => !chamados.Resolvido);
                        break;
                    case "3":
                        ListarChamados(chamados => true);
                        break;
                    case "4":
                        MarcarChamadoComoResolvido();
                        break;
                    case "5":
                        Console.WriteLine("Saindo do sistema de chamados...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != "5");
        }

 
        private void AbrirNovoChamado()
        {
            Console.Write("Digite o título do chamado: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite a descrição do chamado: ");
            string descricao = Console.ReadLine();

            Prioridade prioridade = ObterPrioridadeDoUsuario();

            var novoChamado = new Chamado(titulo, descricao, prioridade);
            _chamados.Add(novoChamado);

            Console.WriteLine("=> Chamado aberto com sucesso!");
        }

      
        /// <param name="filtro">Uma função para filtrar quais chamados exibir.</param>
        private void ListarChamados(Func<Chamado, bool> filtro)
        {
            Console.WriteLine("\n--- Lista de Chamados ---");
            var chamadosParaExibir = _chamados.Where(filtro).OrderByDescending(c => c.Prioridade).ToList();

            if (!chamadosParaExibir.Any())
            {
                Console.WriteLine("Nenhum chamado encontrado para este filtro.");
                return;
            }

            foreach (var chamado in chamadosParaExibir)
            {
                Console.WriteLine(chamado);
                Console.WriteLine("--------------------");
            }
        }

  
        private void MarcarChamadoComoResolvido()
        {
            Console.Write("Digite o título do chamado a ser resolvido: ");
            string titulo = Console.ReadLine();

            var chamado = _chamados.FirstOrDefault(c => c.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (chamado != null)
            {
                chamado.Resolvido = true;
                Console.WriteLine("=> Chamado marcado como resolvido!");
            }
            else
            {
                Console.WriteLine("Chamado não encontrado.");
            }
        }

      
        private Prioridade ObterPrioridadeDoUsuario()
        {
            while (true)
            {
                Console.WriteLine("Defina a prioridade:");
                Console.WriteLine("  1 - Baixa");
                Console.WriteLine("  2 - Média");
                Console.WriteLine("  3 - Alta");
                Console.Write("Opção: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": return Prioridade.Baixa;
                    case "2": return Prioridade.Media; 
                    case "3": return Prioridade.Alta;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, digite 1, 2 ou 3.");
                        break;
                }
            }
        }
    }
}
