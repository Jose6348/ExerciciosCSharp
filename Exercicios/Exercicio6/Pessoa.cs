namespace Exercicios.Exercicio6
{
    public class Pessoa
    {
        public static void Executar()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
