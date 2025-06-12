
// Remova o "See https://aka.ms/new-console-template for more information" se não precisar.

using SeuProjeto.Exercicios.Main.Exercicio1; 
using SeuProjeto.Exercicios.Main.Exercicio2; 

Console.WriteLine("Escolha o exercício para executar:");
Console.WriteLine("1 - Exercício 1");
Console.WriteLine("2 - Exercício 2");
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
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
