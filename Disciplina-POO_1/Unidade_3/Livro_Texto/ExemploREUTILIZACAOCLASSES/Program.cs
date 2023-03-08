
namespace ExemploREUTILIZACAOCLASSES
{
    class Data
    {
        // Atributos
        int dia;
        int mes;
        int ano;

        // Construtor
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        // Sobrescrita
        public override String ToString()
        {
            return dia + "/" + mes + "/" + ano;
        }
    } // Fim class Data

    public class Hora
    {
        // Atributos;
        int hora;
        int minuto;
        int segundo;

        // Construtor
        public Hora(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }

        // Sobrescrita
        public override String ToString()
        {
            return hora + ":" + minuto + ":" + segundo;
        }

    } // Fim class Hora

    class DataHora
    {
        // Atributos
        private Data estaData;
        private Hora estaHora;

        // Construtor
        public DataHora(int hora, int minuto, int segundo, int dia, int mes, int ano)
        {
            estaData = new Data(dia, mes, ano);
            estaHora = new Hora(hora, minuto, segundo);
        }

        // Construtor - sobrecarga
        public DataHora(int dia, int mes, int ano)
        {
            estaData = new Data(dia, mes, ano);
            estaHora = new Hora(0, 0, 0);
        }

        // Sobrescrita
        public override String ToString()
        {
            return estaData.ToString() + " " + estaHora.ToString();
        }

    } // Fim class DataHora

    class Program
    {
        static void Main(string[] args)
        {
            DataHora agora = new DataHora(10, 5, 30, 12, 10, 2014);

            Console.WriteLine();
            Console.WriteLine(agora.ToString());
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }

    } // Fim class Program

}// Fim namespace ExemploREUTILIZACAOCLASSES

