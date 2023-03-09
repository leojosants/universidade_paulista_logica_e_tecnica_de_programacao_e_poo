// Início namespace Pergunta5
namespace Pergunta5
{

    // Início class Vegetal1
    class Vegetal1
    {
        // Atributo
        public string especie;
    }
    // Fim class Vegetal1

    // Início class Legume : Vegetal
    class Legume : Vegetal1
    {
        public string nome;
    }
    // Fim class Legume : Vegetal

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Legume l = new Legume();
            l.especie = "lactuca Sativa";
            l.nome = "Alface";

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace Pergunta5
