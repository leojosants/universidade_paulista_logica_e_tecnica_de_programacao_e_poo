// Início namespace ExemploCLASSEOBJECT
namespace ExemploCLASSEOBJECT
{
    // Início class Pessoa
    class Pessoa
    {
        // Atributos
        public string nome;
        public string telefone;

        // Construtor
        public Pessoa(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        // Método sobrescrito
        public override bool Equals(object obj)
        {
            bool igual = false;
            Pessoa pessoa;

            if (obj is Pessoa)
            {
                pessoa = (Pessoa)obj;
                if (this.nome == pessoa.nome && this.telefone == pessoa.telefone) { igual = true; }
            }

            return igual;
        }

        // Método sobrescrito - Exibindo dados
        public override string ToString()
        {
            return String.Format("Nome: {0} \t Telefone: {1}", nome, telefone);
        }
    }
    //  Fim class Pessoa

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Leonardo", "032999447711");
            Pessoa pessoa2 = new Pessoa("Dalva", "032999447712");

            Console.WriteLine();

            if (pessoa1 == pessoa2) { Console.WriteLine("pessoa1 == pessoa2"); }
            else { Console.WriteLine("pessoa1 != pessoa2"); }

            if (pessoa1.Equals(pessoa2)) { Console.WriteLine("pessoa1 é igual a pessoa2"); }
            else { Console.WriteLine("pessoa1 é diferente de pessoa2"); }

            Console.WriteLine();
            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program
}
// Fim namespace ExemploCLASSEOBJECT
