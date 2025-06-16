
// Remova o "See https://aka.ms/new-console-template for more information" se não precisar.

using SeuProjeto.Exercicios.Main.Exercicio1; 
using SeuProjeto.Exercicios.Main.Exercicio2; 
using SeuProjeto.Exercicios.Main.Exercicio3;
using Exercicios.Main.Exercicio4;
using Exercicios.Exercicio5;
using Exercicios.Exercicio6;
using System.Runtime.CompilerServices;
using Exercicios.Exercicio7;


Console.WriteLine("Escolha o exercício para executar:");
Console.WriteLine("1 - Exercício 1");
Console.WriteLine("2 - Exercício 2");
Console.WriteLine("3 - Exercício 3");
Console.WriteLine("4 - Exercício 4");
Console.WriteLine("5 - Exercício 5");
Console.WriteLine("6 - Exercício 6");
Console.WriteLine("7 - Exercício 7");
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
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
