// Início namespace Pergunta1
namespace Pergunta1
{

    // Inicio class Vegetal
    class Vegetal
    {
        // Atributo
        public string nome;
    }
    // Fim class Vegetal

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Vegetal tomate = new Vegetal();
            Vegetal banana = new Vegetal();

            tomate.nome = "Carmem";
            banana.nome = "Prata";

            Console.WriteLine("\n {0}, {1}", tomate.nome, banana.nome);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace Pergunta1