// Início namespace ExemploHERANCA
namespace ExemploHERANCA
{

    // Início class Pessoa
    class Pessoa
    {
        // Atributo
        public string nome;
        public int telefone;

        // Construtor
        public Pessoa(string nome, int telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
    // Fim class Pessoa

    // Início class Aluno
    class Aluno : Pessoa
    {
        // Atributo
        public string registroAcademico;

        // Contrutor
        public Aluno(string nome, int telefone, string registroAcademico) : base(nome, telefone)
        {
            this.registroAcademico = registroAcademico;
        }
    }
    // Fim class Aluno

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Leonardo", 32997711, "UNIP");
            Console.WriteLine("\n Nome: {0} | Telefone: {1} | RA: {2}", aluno1.nome, aluno1.telefone, aluno1.registroAcademico);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploHERANCA
