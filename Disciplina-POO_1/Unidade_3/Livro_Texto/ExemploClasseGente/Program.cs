
namespace ExemploClasseGente
{
    class Gente
    {
        // Atributo
        public String nome;
        public int idade;

        // Método construtor
        public Gente()
            : this("Jose", 20) // nome = "José"; idade = 20;
        {
        }

        // Método construtor - sobrecarga
        public Gente(String nome)
            : this(nome, 20) // nome = valor; idade = 20;
        {
        }

        // Método construtor - sobrecarga
        public Gente(int valor)
            : this("José",valor) //nome = "José"; idade = valor;
        {
        }

          public Gente(String nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // Método construtor - sobrecarga
        /*public Gente(String valorNome, int valorIdade)
        {
            nome = valorNome;
            idade = valorIdade;
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gente pessoa1 = new Gente("Maria");
            Gente pessoa2 = new Gente("Paulo", 23);

            Console.WriteLine("\nPessoa1 Nome: {0} | Idade: {1}", pessoa1.nome, pessoa1.idade);
            Console.WriteLine("\n -- Fim do Programa -- \n");

            /*
                Gente pessoa1 = new Gente();
                Gente pessoa2 = new Gente();

                pessoa1.nome = "Paulo";
                pessoa1 = pessoa2;

                pessoa2.nome = "Maria";

                Console.WriteLine("\n -- Fim do Programa -- \n");
            */

        }

    }

}