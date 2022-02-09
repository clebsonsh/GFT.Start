using System;
namespace RendaDoFuncionario.src.Classes
{
    public class Funcionario
    {
       public string Nome { get; set; } 
       public string Matricula { get; set; } 
       public double Salario { get; set; }
       public DateTime DataAdmissao { get; set; }
       public string CPF { get; set; } 

        public Funcionario(
            string Nome,
            string Matricula,
            double Salario,
            DateTime DataAdmissao,
            string CPF)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.Salario = Salario;
            this.DataAdmissao = DataAdmissao;
            this.CPF = CPF;
        }

        public void ReceberAumento(double valorAumento)
        {
            this.Salario += valorAumento;
        }

        public double calcularGanhoBrutoAnual()
        {
            return this.Salario * 12;
        }

        public double calcularImposto()
        {   
            const double percentualInss = 0.11;
            double inssFuncionario = 0;
            const double percentualImpostoDeRenda = 0.175;
            const int valorMinimoParaPagarIR = 2500;
            double impostoDeRendaFuncionario = 0;

            inssFuncionario = this.Salario * percentualInss;

            if (this.Salario > valorMinimoParaPagarIR)
            {
                impostoDeRendaFuncionario = (this.Salario - valorMinimoParaPagarIR) * percentualImpostoDeRenda;
            }
            return inssFuncionario + impostoDeRendaFuncionario;
        }

        public double calcularGanhoLiquidoMensal()
        {
            double ganhoLiquidoMensal = this.Salario - calcularImposto();

            return ganhoLiquidoMensal;
        }

        public double calcularGanhoLiquidoAnual()
        {
            double ganhoLiquidoMensal = calcularGanhoLiquidoMensal();
            double ganhoLiquidoAnual = ganhoLiquidoMensal * 12;

            return ganhoLiquidoAnual;
        }
    }
}
