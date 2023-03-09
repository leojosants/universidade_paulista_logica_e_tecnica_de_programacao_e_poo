// Início namespace ExemploPOLIMORFISMO
namespace ExemploPOLIMORFISMO
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
        // Método
        public static void Escola(Aluno aluno)
        {
            Console.WriteLine("O aluno {0} entrou na escola!", aluno.nome);
        }

        // Método
        public static void Lanchonete(Pessoa pessoa)
        {
            Console.WriteLine("A pessoa {0} entrou na lanchonete!", pessoa.nome);
        }

        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Leonardo", 222222, "UNIP");

            Pessoa pessoa1 = new Pessoa("Maria", 444444);

            Console.WriteLine();

            Lanchonete(pessoa1);
            Lanchonete(aluno1);

            Escola(aluno1);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploPOLIMORFISMO