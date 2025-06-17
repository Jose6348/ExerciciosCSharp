namespace Exercicios.Main.Exercicio7
{
    public class Conta
    {
        public int Numero { get; }
        public Cliente Titular { get; }
        private decimal saldo;

        public Conta(int numero, Cliente titular)
        {
            Numero = numero;
            Titular = titular;
            saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public decimal ConsultarSaldo()
        {
            return saldo;
        }
    }
}
