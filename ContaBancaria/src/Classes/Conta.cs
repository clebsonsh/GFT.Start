using System;
namespace ContaBancaria.src.Classes
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
    }

    public double rendimento(double redimentoConta)
    {
        return this.Saldo * redimentoConta;
    }
}
