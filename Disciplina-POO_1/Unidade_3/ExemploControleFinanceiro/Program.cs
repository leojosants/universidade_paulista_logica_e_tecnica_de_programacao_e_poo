
namespace ExemploControleFinanceiro
{
    class Conta
    {
        // Atributos
        public String nome;
        public double valor;
        public String dataDeVencimento;
        public String dataDePagamento;

        // Método construtor
        public Conta()
        {
            this.nome = "";
            this.valor = 0;
            this.dataDePagamento = "";
            this.dataDePagamento = "";
        }
    }

    class Categoria
    {
        // Atributos
        public String nome;
        public String tipo;

        // Método construtor
        public Categoria()
        {
            this.nome = "";
            this.tipo = "";
        }
    }

    class TipoDePagamento
    {
        // Atributos
        public String nome;

        // Método construtor
        public TipoDePagamento()
        {
            this.nome = "";
        }
    }

    class Caixa
    {
        // Atributos
        public String nome;
        public double saldo;

        // Método construtor
        public Caixa()
        {
            this.nome = "";
            this.saldo = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-- Programa Finalizado --\n");
        }
    }

}