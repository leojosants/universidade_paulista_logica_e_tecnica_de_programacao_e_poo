// Início namespace ExemploHERANCA
namespace ExemploHERANCA
{
    // Início class Pai
    class Pai
    {
        // Construtor
        public Pai()
        {
            Console.WriteLine("Construtor Pai");
        }

        // Sobrecarga
        public Pai(string nome)
        {
            Console.WriteLine("Sou o Construtor com parâmetros da classe Pai " + nome);
        }

        // Método
        public void papi(string nome)
        {
            Console.WriteLine("Superclasse Pai, " + nome);
        }
    }
    // Fim class Pai

    // Início class Filho
    class Filho : Pai
    {
        // Construtor
        public Filho()
        {
            Console.WriteLine("Construtor Filho");
        }

        // Sobrecarga
        public Filho(string nome)
            : base(nome)
        {
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

            Filho f = new Filho("do Junior");

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
    // Fim class Program
}
// Fim namespace ExemploHERANCA