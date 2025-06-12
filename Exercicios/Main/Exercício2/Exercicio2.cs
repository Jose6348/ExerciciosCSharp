

using System;

namespace SeuProjeto.Exercicios.Main.Exercicio2 
{
    public class Exercicio2 
    {
        public static void Executar() 
        {
            Console.WriteLine("Executando Exercício 2: Tabuada");
            Console.Write("Digite um número para ver a tabuada: ");
            string input = Console.ReadLine();
            try
            {
                int numero = int.Parse(input);
                Console.WriteLine($"\nTabuada do {numero}:\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            }
        }
    }
}
