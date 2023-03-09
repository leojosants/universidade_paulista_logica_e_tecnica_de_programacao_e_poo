// Início namespace ExemploMODIFICADORSTATIC
namespace ExemploMODIFICADORSTATIC
{

    // Início class Classe
    class Classe
    {
        // Atributo e get - (contador)
        private static int contador;
        public int GetContador() { return contador; }

        // Construtor
        public Classe() { contador++; }

        // Método
        public static double Multiplique(double a, double b) { return a * b; }
    }
    // Fim class Classe

    // Início class Program
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine();

            Classe obj1 = new Classe();
            Classe obj2 = new Classe();            
            Classe obj3 = new Classe();

            Console.WriteLine("Contador de obj1: {0}", obj1.GetContador());
            Console.WriteLine("Contador de obj1: {0}", obj2.GetContador());
            Console.WriteLine("Contador de obj1: {0}", obj3.GetContador());

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploMODIFICADORSTATIC