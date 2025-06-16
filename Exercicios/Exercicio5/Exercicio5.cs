namespace Exercicios.Exercicio5
{
    public class Exercicio5
    {
        public static void Executar()
        {
            Console.Write("Digite a palavra a ser invertida: ");

            string palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("Nenhuma palavra foi fornecida.");
                return;
            }

            // Inverte a palavra usando o método ToCharArray e Array.Reverse
            char[] letras = palavra.ToCharArray();
            Array.Reverse(letras);
            string palavraInvertida = new string(letras);


            Console.WriteLine($"Palavra original: {palavra}");
            Console.WriteLine($"Palavra invertida: {palavraInvertida}");



        }
    }
}
