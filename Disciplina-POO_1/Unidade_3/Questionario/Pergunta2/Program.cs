// Início namespace Pergunta2
namespace Pergunta2
{

    // Inicio class Vegetal
    class Vegetal
    {
        // Atributo
        public string nome;
    }
    // Fimclass Vegetal

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Vegetal tomate = new Vegetal();
            Vegetal banana = tomate;

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
// Fim namespace Pergunta2
