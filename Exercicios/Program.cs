// See https://aka.ms/new-console-template for more information

Console.Write("Digite um número: ");
string input = Console.ReadLine();

Console.WriteLine($"O número digitado foi: {input}");

try
{
    int numero = int.Parse(input);

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par");
    }

    else
    {
        Console.WriteLine($"O numero {numero}  é impar");
    }
}
catch(FormatException)
{
    Console.WriteLine("Entrada inválida");
} 
