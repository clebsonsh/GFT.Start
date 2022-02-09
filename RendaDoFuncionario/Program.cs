using System;

namespace RendaDoFuncionario
{
    class Program
    {
        static Funcionario funcionario = new Funcionario(
            "Clebson",
            "12345",
            5000,
            DateTime.Now,
            "12345678911" 
        );

        static void Main(string[] args)
        {

            Console.WriteLine(funcionario);
            string opcaoUsuario = GetOpcaoUsuario();

            while (opcaoUsuario != "X")
            {

                Console.Clear();
                switch (opcaoUsuario)
                {
                case "1":
                    Console.Write("Informe o valor do aumento: ");
                    double valorAumento = Convert.ToDouble(Console.ReadLine());
                    funcionario.ReceberAumento(valorAumento);
                    break;
                default:
                    Console.WriteLine("Por favor selecione uma opção válida...");
                    break;
                }
                Console.WriteLine(funcionario);

                opcaoUsuario = GetOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por usar nosso sistema <3");
        }

        private static string GetOpcaoUsuario()
        {
            Console.Write(@"
            ##############################
            Sistema de Renda do Funcionário

            1 - Receber Aumento
            X - Sair

            ##############################

            Por favor selecione uma opção: ");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
