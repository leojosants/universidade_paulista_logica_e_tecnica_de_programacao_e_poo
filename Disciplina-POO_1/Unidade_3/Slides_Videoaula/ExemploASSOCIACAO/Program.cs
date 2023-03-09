// Início namespace ExemploASSOCIACAORSTATIC
namespace ExemploASSOCIACAO
{

    // Início class Endereco
    class Endereco
    {
        // Atributo
        public string logradouro;
        public int numero;
        public string cidade;
    }
    // Fim class Endereco

    // Início class Pessoa
    class Pessoa
    {
        // Atributo
        public string nome;

        // Associacao
        public Endereco residencia;
    }
    // Fim class Pessoa

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa cliente = new Pessoa();
            cliente.nome = "Leonardo";

            Endereco casa = new Endereco();
            casa.logradouro = "Rua das Flores";
            casa.numero = 42;
            casa.cidade = "Beagá";

            cliente.residencia = casa;

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploASSOCIACAO
