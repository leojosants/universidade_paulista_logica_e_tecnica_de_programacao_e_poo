// Início namespace Pergunta2
namespace Pergunta3
{

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            try
            {
                Object texto = "0";
                int n = (int)texto;

                Console.WriteLine(10 / n);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("\n Erro de cast inválido!");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n Erro de conversão de tipos!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\n Erro de referência nula!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n Ocorreu uma divisão por zero");
            }

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace Pergunta2