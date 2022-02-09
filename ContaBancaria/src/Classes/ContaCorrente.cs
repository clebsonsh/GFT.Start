namespace ContaBancaria.src.Classes
{
    public class ContaCorrente: Conta
    {
        public ContaCorrente(int Numero, string Titular, double Saldo)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }
    }
}
