// Início namespace ExemploDELEGACAO
namespace ExemploDELEGACAOACAO
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

    // Início class Hora
    class Hora
    {
        // Atributos
        public int hora;
        public int minuto;
        public int segundo;

        // Construtor
        public Hora(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }
    }// Fim class Hora

    // Início class DataHora
    class DataHora
    {
        // Associação
        public Data estaData;
        public Hora estaHora;

        // Construtor
        public DataHora(int dia, int mes, int ano, int hora, int minuto, int segundo)
        {
            estaData = new Data(dia, mes, ano);
            estaHora = new Hora(hora, minuto, segundo);
        }
    }
    // Fim class DataHora

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploDELEGACAO
