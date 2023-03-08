// Início namespace ExemploMETODOCONSTRUTOR
namespace ExemploMETODOCONSTRUTOR
{

    // Início class Data
    class Data
    {
        // Atributo get e set - dia
        public int dia;
        public int GetDia() { return dia; }
        public void SetDia(int dia)
        {
            if (dia > 0 && dia <= 31)
            {
                this.dia = dia;
            }
        }

        // Atributo get e set - mes
        public int mes;
        public int GetMes() { return mes; }
        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
            }
        }

        // Atributo get e set - ano
        public int ano;
        public int GetAno() { return ano; }
        public void SetAno(int ano)
        {
            this.ano = ano;
        }

        // Construtor
        public Data(int dia, int mes, int ano)
        {
            SetDia(dia);
            SetMes(mes);
            SetAno(ano);
        }
    }
    // Fim class Data

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data(25, 12, 2015);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploMETODOCONSTRUTOR
