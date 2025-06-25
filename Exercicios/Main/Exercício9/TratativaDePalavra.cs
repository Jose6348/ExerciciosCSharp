namespace Exercicios.Main.Exercício9
{
    public class TratativaDePalavra : Exercicio9
    {
        public void ContadorDeLetras(string Palavra)
        {
            if (string.IsNullOrEmpty(Palavra))
            {
                Console.WriteLine("A palavra não pode ser vazia.");
                return;
            }
            int contador = 0;
            foreach (char letra in Palavra)
            {
                if (char.IsLetter(letra))
                {
                    contador++;
                }
            }
            Console.WriteLine($"A palavra '{Palavra}' contém {contador} letras.");
        }
    }
}
