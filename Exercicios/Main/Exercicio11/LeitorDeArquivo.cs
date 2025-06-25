namespace Exercicios.Main.Exercicio11
{
    public class LeitorDeArquivo
    {
        public void LerArquivo()
        {
            string caminhoArquivo = @"C:\Users\jose.falasco\source\repos\Exercicios\Exercicios\Main\Exercicio11\Nomes.txt";

            try
            {
                if (!System.IO.File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Arquivo não encontrado.");
                    return;
                }
                string[] linhas = System.IO.File.ReadAllLines(caminhoArquivo);
                Console.WriteLine("--- Conteúdo do Arquivo ---");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }
        }
    }
}
