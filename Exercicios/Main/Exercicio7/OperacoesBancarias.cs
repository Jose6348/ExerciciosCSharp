namespace Exercicios.Main.Exercicio7
{
    public class OperacoesBancarias
    {
        public static void Executar()
        {
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine() ?? "Cliente";

            Console.Write("Digite o número da conta: ");
            int numeroConta;
            while (!int.TryParse(Console.ReadLine(), out numeroConta))
            {
                Console.Write("Número inválido. Digite novamente: ");
            }

            Console.Write("Digite o nome do banco: ");
            string nomeBanco = Console.ReadLine() ?? "Banco";

            var cliente = new Cliente(nomeCliente);
            var conta = new Conta(numeroConta, cliente);
            var banco = new Banco(nomeBanco);

            banco.AdicionarConta(conta);

            Console.Write("Digite o valor para depósito: ");
            decimal valorDeposito;
            while (!decimal.TryParse(Console.ReadLine(), out valorDeposito) || valorDeposito <= 0)
            {
                Console.Write("Valor inválido. Digite novamente: ");
            }
            conta.Depositar(valorDeposito);
            Console.WriteLine($"Saldo após depósito: {conta.ConsultarSaldo()}");

            Console.Write("Digite o valor para saque: ");
            decimal valorSaque;
            while (!decimal.TryParse(Console.ReadLine(), out valorSaque) || valorSaque <= 0)
            {
                Console.Write("Valor inválido. Digite novamente: ");
            }

            if (conta.Sacar(valorSaque))
                Console.WriteLine("Saque realizado com sucesso.");
            else
                Console.WriteLine("Saque não realizado.");

            Console.WriteLine($"Saldo final: {conta.ConsultarSaldo()}");
        }
    }
}
