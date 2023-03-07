
namespace DesvioCondicionalIFELSE
{
    class Program 
    {
        static void Main(string[] args) 
        {
            double numero = 0;

            Console.Write("\nDigite um número: ");

            numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("O número {0} é: PAR", numero);
            }
            else {
                Console.WriteLine("O número {0} é: ÍMPAR", numero);
            }

            Console.WriteLine();
        }
    }
}
