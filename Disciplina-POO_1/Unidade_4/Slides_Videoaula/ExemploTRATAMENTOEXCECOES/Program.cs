// Início namespace ExemploTRATAMENTOEXCECOES
namespace ExemploTRATAMENTOEXCECOES
{
    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Console.WriteLine();

            int numero1 = LeiaNumero("Digite o primeiro número: ");
            int numero2 = LeiaNumero("Digite o segundo número: ");

            try { Console.WriteLine("\n{0} / {1} = {2}", numero1, numero2, (numero1 / numero2)); }
            catch (DivideByZeroException) { Console.WriteLine("--> Não é possível fazer uma divisão por zero!"); }
            finally
            {
                Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
                Console.ReadKey();
                Console.WriteLine("\n -- Fim do Programa -- \n");
            }
        }
        // Fim Main

        // Método
        static int LeiaNumero(string mensagem)
        {
            int numero = 0;
            bool correto = false;

            do
            {
                try
                {
                    Console.Write(mensagem);
                    
                    numero = Convert.ToInt32(Console.ReadLine());
                    correto = true;
                }
                catch (FormatException) { Console.WriteLine("--> Você não digitou um número inteiro. Tente novamente! \n"); }

            } while (!correto);

            return numero;
        }
    }
    // Fim class Program
}
// Fim namespace ExemploTRATAMENTOEXCECOES
