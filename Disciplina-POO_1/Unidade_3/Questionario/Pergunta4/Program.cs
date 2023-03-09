// Início namespace Pergunta4
namespace Pergunta4
{

    // Início class Data
    class Data
    {
        // Atributos
        public int dia;
        public int mes;
        public int ano;

        // Construtor
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
    }
    // Fim class Data

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace Pergunta4
