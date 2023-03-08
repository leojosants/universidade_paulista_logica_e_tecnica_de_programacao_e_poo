
// Início namespace ExemploABSTRACAODECLASSES
namespace ExemploABSTRACAODECLASSES
{

    // Início class Pessoa
    class Pessoa
    {
        public string nome;
        public string email;
        public int telefone;
    }
    // Fim class Pessoa

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando classe
            Pessoa p1 = new Pessoa();
            p1.nome = "Joaquim";
            p1.email = "joaquim@joaqui.com";
            p1.telefone = 111111111;

            Pessoa p2 = new Pessoa();
            p2.nome = "Manoel";
            p2.email = "manoel@manoel.com";
            p2.telefone = 22222222;

            Console.WriteLine();
            Console.WriteLine("Nome: {0} \t Email: {1} \t Telefone: {2}", p1.nome, p1.email, p1.telefone);
            Console.WriteLine("Nome: {0} \t Email: {1} \t Telefone: {2}", p2.nome, p2.email, p2.telefone);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
    // Fim class Program

}
// Fim namespace ExemploABSTRACAODECLASSES
