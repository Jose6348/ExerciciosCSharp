
namespace Exercicios.Main.Exercicio4
{
    public class Exercicio4
    {
        public static void Executar()
        {
            int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 20];

            if (numeros.Length == 0)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            int maiorNumero = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            Console.WriteLine($"O maior número na lista é: {maiorNumero}");
        }
    }
}
