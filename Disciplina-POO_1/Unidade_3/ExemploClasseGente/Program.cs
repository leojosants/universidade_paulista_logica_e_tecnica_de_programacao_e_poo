
namespace ExemploClasseGente
{
    class Gente
    {
        // Atributo
        public String nome;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Gente pessoa1 = new Gente();
            Gente pessoa2 = new Gente();

            pessoa1.nome = "Paulo";
            pessoa1 = pessoa2;

            pessoa2.nome = "Maria";

            Console.WriteLine("\nPessoa1 nome: {0}", pessoa1.nome);
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }

    }

}