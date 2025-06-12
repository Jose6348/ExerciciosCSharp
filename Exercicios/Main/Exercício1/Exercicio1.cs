
using System;

namespace SeuProjeto.Exercicios.Main.Exercicio1 
{
    public class Exercicio1 
    {
        public static void Executar() 
        {
            Console.WriteLine("Executando Exercício 1: Par ou Ímpar");
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();
            try
            {
                int numero = int.Parse(input);
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} é ímpar.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            }
        }
    }
}
