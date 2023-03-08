
namespace ExemploMETODOCONSTRUTOR
{

    class Gente
    {
        // Atributos
        public String nome;
        public int idade;

        // Método construtor
        public Gente()
        {
            nome = "José";
            idade = 20;
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            Gente pessoa1 = new Gente();

            Console.WriteLine("\n Nome: {0}\n idade: {1}", pessoa1.nome, pessoa1.idade);
            Console.WriteLine("\n-- Programa Finalizado --\n");
        }
    }
}




