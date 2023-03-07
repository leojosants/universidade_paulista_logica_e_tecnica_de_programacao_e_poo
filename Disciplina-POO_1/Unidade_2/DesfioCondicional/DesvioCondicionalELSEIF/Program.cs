
namespace DesvioCondicionalELSEIF
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int a, b = 0;

            Console.Write("\nDigite um número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b) {
                Console.WriteLine("O primeiro número --> {0} é maior que o segundo número --> {1}!", a, b);
            }
            else if (a < b) {
                Console.WriteLine("O segundo número --> {0} é maior que o primeiro número --> {1}!", b, a);
            }
            else {
                Console.WriteLine("O primeiro número --> {0} e o segundo --> {1} número são iguais!", b, a);
            }

            Console.WriteLine();
        }
    }
}
