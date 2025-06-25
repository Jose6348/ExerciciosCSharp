namespace Exercicios.Main.Exercicio11
{
    public class ExecutarArquivo
    {
        public void Iniciar()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            leitor.LerArquivo();
            Console.WriteLine("\n--- Ordenando o arquivo ---");
            string caminhoArquivo = @"C:\Users\jose.falasco\source\repos\Exercicios\Exercicios\Main\Exercicio11\Nomes.txt";
            string[] linhas = System.IO.File.ReadAllLines(caminhoArquivo);
            
            OrdenadorDeArquivo ordenador = new OrdenadorDeArquivo();
            ordenador.CriarArquivoOrdenado(linhas, caminhoArquivo);
        }
    }
}
