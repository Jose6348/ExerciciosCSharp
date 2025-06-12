// See https://aka.ms/new-console-template for more information

using System;

public partial class Program // Adicionado o modificador 'partial' para resolver o erro CS0260
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();
        try
        {
            int numero = int.Parse(input);

            Console.WriteLine($"\nTabuada do {numero}");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida");
        }
    }
}
