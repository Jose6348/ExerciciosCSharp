using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuProjeto.Exercicios.Main.Exercicio3
{
    public class Exercicio3
    {
        public static void Executar()
        {
            Console.Write("Forneça a primeira nota :");
            string primeiraNotaInput = Console.ReadLine();

            Console.Write("Forneça a Segunda nota :");
            string segundaNotaInput = Console.ReadLine();

            Console.Write("Forneça a Terceira nota :");
            string terceiraNotaInput = Console.ReadLine();

            try
            {
                double nota1 = double.Parse(primeiraNotaInput);
                double nota2 = double.Parse(segundaNotaInput);
                double nota3 = double.Parse(terceiraNotaInput);

                double somaDasNotas = nota1 + nota2 + nota3;

                double media = somaDasNotas / 3;

                if (media >= 7)
                {
                    Console.WriteLine($"A média é {media}. O aluno está aprovado.");
                }
                else if (media >= 5)
                {
                    Console.WriteLine($"A média é {media}. O aluno está em recuperação.");
                }
                else
                {
                    Console.WriteLine($"A média é {media}. O aluno está reprovado.");
                }
               
            }

        }

    }
}
