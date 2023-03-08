// Início namespace ExemploHERANCA
namespace ExemploHERANCA
{
    // Início class Pai
    class Pai
    {
        // Construtor
        public Pai()
        {
            Console.WriteLine("Construtor pai");
        }

        // Método
        public void papi(string nome)
        {
            Console.WriteLine("Superclasse pai, " + nome);
        }
    }
    // Fim class Pai

    // Início class Filho
    class Filho : Pai
    {
        // Construtor
        public Filho()
        {
            Console.WriteLine("Construtor filho");
        }

        // Método
        public void junior()
        {
            Console.WriteLine("Sou método júnior");
        }
    }
    // Fim class Filho

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Filho f = new Filho();
            f.papi("do Junior");

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
    // Fim class Program
}
// Fim namespace ExemploHERANCA