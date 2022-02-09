using System.Globalization;
namespace ContaBancaria.src.Classes
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca(int Numero, string Titular, double Saldo)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }
    }
}
