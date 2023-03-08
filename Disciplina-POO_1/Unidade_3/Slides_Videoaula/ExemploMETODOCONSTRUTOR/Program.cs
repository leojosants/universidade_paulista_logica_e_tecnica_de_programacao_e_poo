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

        // Sobrecarga
        // public Data()
        // {
        //     SetDia(1);
        //     SetMes(1);
        //     SetAno(1);
        // }

        // Sobrecarga
        public Data() : this(1, 1, 1) { }

    }
    // Fim class Data

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Data data1 = new Data();
            Console.WriteLine("Data data1: {0}/{1}/{2}", data1.GetDia(), data1.GetMes(), data1.GetAno());

            Data data2 = new Data(25, 12, 2015);
            Console.WriteLine("Data data2: {0}/{1}/{2}", data2.GetDia(), data2.GetMes(), data2.GetAno());

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploMETODOCONSTRUTOR
