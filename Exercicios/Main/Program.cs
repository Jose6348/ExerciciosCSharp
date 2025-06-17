// Remova o "See https://aka.ms/new-console-template for more information" se não precisar.

using Exercicios.Main.Exercicio4;
using Exercicios.Main.Exercicio5;
using Exercicios.Main.Exercicio6;
using Exercicios.Main.Exercicio7;
// Adicione a referência para o Exercício 8
using Exercicios.Main.Exercicio8;
using SeuProjeto.Exercicios.Main.Exercicio1;
using SeuProjeto.Exercicios.Main.Exercicio2;
using SeuProjeto.Exercicios.Main.Exercicio3;
using System.Runtime.CompilerServices;

Console.WriteLine("Escolha o exercício para executar:");
Console.WriteLine("1 - Exercício 1");
Console.WriteLine("2 - Exercício 2");
Console.WriteLine("3 - Exercício 3");
Console.WriteLine("4 - Exercício 4");
Console.WriteLine("5 - Exercício 5");
Console.WriteLine("6 - Exercício 6");
Console.WriteLine("7 - Exercício 7");
Console.WriteLine("8 - Sistema de Tarefas (Exercício 8)"); // Opção adicionada
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
        var client = new Cliente("Maria");
        var conta = new Conta(123, client);
        var banco = new Banco("SantoAndre");

        banco.AdicionarConta(conta);

        conta.Depositar(500);
        Console.WriteLine($"Saldo após depósito: {conta.ConsultarSaldo()}");

        if (conta.Sacar(200))
            Console.WriteLine("Saque realizado com sucesso.");
        else
            Console.WriteLine("Saque não realizado.");

        Console.WriteLine($"Saldo final: {conta.ConsultarSaldo()}");
        break;

    // Novo case para o Exercício 8
    case "8":
        ExecutarSistemaDeTarefas();
        break;

    default:
        Console.WriteLine("Opção inválida.");
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