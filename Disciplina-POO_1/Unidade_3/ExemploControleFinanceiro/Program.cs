
namespace ExemploControleFinanceiro
{
    class Conta
    {
        // Atributos
        public string nome;
        public double valor;
        public string dataDeVencimento;
        public string dataDePagamento;

        // Método construtor
        public Conta()
        {
            this.nome = "";
            this.valor = 0;
            this.dataDePagamento = "";
            this.dataDePagamento = "";
        }

        // Método construtor - sobrecarga
        public Conta(string fNome, double fValor)
        {
            this.nome = fNome;
            this.valor = fValor;
        }

        public double RetornarSaldo()
        {
            return this.valor;
        }

        public String RetornarNome()
        {
            return this.nome;
        }

        public void DefineSaldo(double valor)
        {
            this.valor = valor;
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

        // Método construtor - sobrecarga
        public Categoria(string fNome, string fTipo)
        {
            this.nome = fNome;
            this.tipo = fTipo;
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

        // Método construtor
        public TipoDePagamento(string fNome)
        {
            this.nome = fNome;
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

        // Método construtor - sobrecarga
        public Caixa(string fNome, double fSaldo)
        {
            this.nome = fNome;
            this.saldo = fSaldo;
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