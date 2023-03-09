// Início namespace ExemploTRATAMENTOEXCECOES
namespace ExemploTRATAMENTOEXCECOES
{

    // Início class Funcionario
    class Funcionario
    {
        // Método
        public void AumentaSalario(double aumento)
        {
            if (aumento < 0)
            {
                ArgumentException erro = new ArgumentException();
                throw erro;
            }
        }
    }
    // Fim class Funcionario

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            /* TESTE 1

                // String v = "Três";
                String v2 = "3";

                try
                {
                    Console.WriteLine();

                    // double num = Convert.ToDouble(v); // Converte um string em número
                    // Console.WriteLine(num);

                    double num2 = Convert.ToDouble(v2); // Converte um string em número
                    Console.WriteLine(num2);
                }
                catch (System.FormatException err)
                {
                    Console.WriteLine();
                    Console.WriteLine("Erro de formato, mensagem: {0}", err.Message);
                }

                Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
                Console.ReadKey();
                Console.WriteLine("\n -- Fim do Programa -- \n");
            */

            // TESTE 2
            Funcionario funcionario1 = new Funcionario();

            try
            {
                funcionario1.AumentaSalario(-1000);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine();
                System.Console.WriteLine("Houve um ArgumentException ao aumentar o salário!");
            }

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploTRATAMENTOEXCECOES