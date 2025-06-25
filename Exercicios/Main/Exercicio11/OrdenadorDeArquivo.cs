namespace Exercicios.Main.Exercicio11
{
    public class OrdenadorDeArquivo
    {
        public void CriarArquivoOrdenado(string[] linhasParaOrdenar, string caminhoArquivoOriginal)
        {
            if (linhasParaOrdenar == null || linhasParaOrdenar.Length == 0)
            {
                Console.WriteLine("Nenhuma linha para ordenar.");
                return;
            }
            try
            {
                Array.Sort(linhasParaOrdenar);

                string diretorio = Path.GetDirectoryName(caminhoArquivoOriginal);

                string nomeArquivoOrdenado = Path.GetFileNameWithoutExtension(caminhoArquivoOriginal) + "_Ordenado.txt";
                string caminhoArquivoOrdenado = Path.Combine(diretorio, nomeArquivoOrdenado);

                File.WriteAllLines(caminhoArquivoOrdenado, linhasParaOrdenar);

                Console.WriteLine($"Arquivo ordenado criado com sucesso: {caminhoArquivoOrdenado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao criar o arquivo ordenado: {ex.Message}");
            }
        }
    }
}
