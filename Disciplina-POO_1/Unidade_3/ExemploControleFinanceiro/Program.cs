
namespace ExemploControleFinanceiro
{
    class Conta
    {
        // Atributo, get e set (nome)
        private String nome;
        public string Nome
        {
            set
            {
                nome = value;
            }
            get
            {
                return nome;
            }
        }

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

        // Método construtor - sobrecarga
        public Conta(string fNome, double fValor)
        {
            // Comandos de iniciação
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

        public double DefineSaldo(double valor)
        {
            this.valor = valor;
            return this.RetornarSaldo();
        }
    }

    class Categoria
    {
        // Atributo, get e set (nome)
        public String nome;
        public String GetNome()
        {
            return nome;
        }
        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        // Atributo, get e set (tipo)
        public String tipo;
        public String GetTipo()
        {
            return tipo;
        }
        public void SetTipo(String tipo)
        {
            this.tipo = tipo;
        }

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

        // get e set
        public String GetNome()
        {
            return nome;
        }
        public void SetNome(String nome)
        {
            this.nome = nome;
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

        // get e set
        public String GetNome()
        {
            return nome;
        }
        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public double GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
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