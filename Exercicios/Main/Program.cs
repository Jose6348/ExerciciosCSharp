// Remova o "See https://aka.ms/new-console-template for mais informações" se não precisar.

using Exercicios.Main.Exercicio4;
using Exercicios.Main.Exercicio5;
using Exercicios.Main.Exercicio6;
using Exercicios.Main.Exercicio7;
using Exercicios.Main.Exercicio8;
using Exercicios.Main.Exercício9;
using Exercicios.Main.Exerciico10;
using Exercicios.Main.Exercicio11;
using Exercicios.Main.Exercicio12;
using SeuProjeto.Exercicios.Main.Exercicio1;
using SeuProjeto.Exercicios.Main.Exercicio2;
using SeuProjeto.Exercicios.Main.Exercicio3;


Console.WriteLine("Escolha o exercício para executar:");
Console.WriteLine("1 - Exercício 1");
Console.WriteLine("2 - Exercício 2");
Console.WriteLine("3 - Exercício 3");
Console.WriteLine("4 - Exercício 4");
Console.WriteLine("5 - Exercício 5");
Console.WriteLine("6 - Exercício 6");
Console.WriteLine("7 - Exercício 7");
Console.WriteLine("8 - Sistema de Tarefas (Exercício 8)"); 
Console.WriteLine("9 - Tratativa de Palavras (Exercício 9)"); 
Console.WriteLine("10 - Sistema de Chamados (Exercício 10)");
Console.WriteLine("11 - Exercício 11 (Tratamento de Exceções)");
Console.WriteLine("12 - Exercício 12 (Listagem de Produtos)");
Console.Write("Opção: ");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Exercicio1.Executar();
        break;
    case "2":
        Exercicio2.Executar();
        break;
    case "3":
        Exercicio3.Executar();
        break;
    case "4":
        Exercicio4.Executar();
        break;
    case "5":
        Exercicio5.Executar();
        break;
    case "6":
        Pessoa.Executar();
        break;

    case "7":
        OperacoesBancarias.Executar();
        break;

    case "8":
        ExecutarSistemaDeTarefas();
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;

    case "9":

        var tratadorDePalavra = new TratativaDePalavra();

    Console.Write("Digite uma palavra: ");
    string palavra = Console.ReadLine();
    
    tratadorDePalavra.ContadorDeLetras(palavra);
    break;

    case "10":
        var sistemaChamados = new ExecutarChamado();
        sistemaChamados.Iniciar();
        break;
    case "11":
        var tratamentoExcecoes = new ExecutarArquivo();
        tratamentoExcecoes.Iniciar();
        break;

    case "12":
        var ListagemDeProdutos = new ExecutarListagem();
        ListagemDeProdutos.FiltrarEExibirProdutosCaros();
        break;
}

// Método para controlar o menu do Sistema de Tarefas
static void ExecutarSistemaDeTarefas()
{
    var sistema = new SistemaTarefas();
    string opcaoTarefa;

    do
    {
        Console.WriteLine("\n--- Sistema de Gerenciamento de Tarefas ---");
        Console.WriteLine("1 - Adicionar Tarefa");
        Console.WriteLine("2 - Listar Tarefas");
        Console.WriteLine("3 - Marcar Tarefa como Concluída");
        Console.WriteLine("4 - Sair");
        Console.Write("Escolha uma opção: ");
        opcaoTarefa = Console.ReadLine();

        switch (opcaoTarefa)
        {
            case "1":
                Console.Write("Digite o título da tarefa: ");
                string titulo = Console.ReadLine();
                Console.Write("Digite a descrição da tarefa: ");
                string descricao = Console.ReadLine();
                sistema.AdicionarTarefa(titulo, descricao);
                break;

            case "2":
                sistema.ListarTarefas();
                break;

            case "3":
                Console.Write("Digite o título da tarefa a ser concluída: ");
                string tituloParaConcluir = Console.ReadLine();
                sistema.MarcarComoConcluida(tituloParaConcluir);
                break;

            case "4":
                Console.WriteLine("Saindo do sistema de tarefas...");
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

    } while (opcaoTarefa != "4");
}
 