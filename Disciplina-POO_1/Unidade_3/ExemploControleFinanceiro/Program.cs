// Início namespace ExemploControleFinanceiro
namespace ExemploControleFinanceiro
{
    // Início class Conta
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

        // Atributos
        public double valor;
        public String dataDeVencimento;
        public String dataDePagamento;
        public Categoria categoriaDaConta;
        public TipoDePagamento tipoDePagamentoDaConta;
        public Caixa caixaDaConta;

        // Método construtor
        public Conta()
        {
            this.nome = "";
            this.valor = 0;
            this.dataDePagamento = "";
            this.dataDePagamento = "";
            categoriaDaConta = new Categoria();
            tipoDePagamentoDaConta = new TipoDePagamento();
            caixaDaConta = new Caixa();
        }

        // Método construtor - sobrecarga
        public Conta(string fNome, double fValor)
        {
            // Comandos de iniciação
            this.nome = fNome;
            this.valor = fValor;
            categoriaDaConta = new Categoria();
            tipoDePagamentoDaConta = new TipoDePagamento();
            caixaDaConta = new Caixa();
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
    // Fim class Conta

    // Início class Categoria
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
    // Fim class Categoria

    // Início class TipoDePagamento
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
    // Fim class TipoDePagamento

    // Início class Caixa
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
    // Fim class Caixa

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Controle de Contas");
            Console.WriteLine();

            Conta c1 = new Conta("Conta de luz", 100);
            c1.categoriaDaConta.SetNome("Despesas da casa");
            c1.tipoDePagamentoDaConta.SetNome("PAGAMENTO");

            Conta c2 = new Conta("Conta de água", 60);
            c2.categoriaDaConta.SetNome("Despesas da casa");
            c2.tipoDePagamentoDaConta.SetNome("PAGAMENTO");

            Conta c3 = new Conta("Salário", 1000);
            c3.categoriaDaConta.SetNome("Salários");
            c3.tipoDePagamentoDaConta.SetNome("RECEBIMENTO");

            Console.WriteLine("CONTA \t\t\t CATEGORIA \t\t\t TIPO \t\t\t VALOR");

            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}",
                c1.Nome,
                c1.categoriaDaConta.GetNome(),
                c1.tipoDePagamentoDaConta.GetNome(),
                c1.RetornarSaldo()
            );

            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}",
               c2.Nome,
               c2.categoriaDaConta.GetNome(),
               c2.tipoDePagamentoDaConta.GetNome(),
               c2.RetornarSaldo()
           );

            Console.WriteLine("{0} \t\t {1} \t\t\t {2} \t\t {3}",
               c3.Nome,
               c3.categoriaDaConta.GetNome(),
               c3.tipoDePagamentoDaConta.GetNome(),
               c3.RetornarSaldo()
           );

            Console.WriteLine("\n-- Programa Finalizado --\n");
        }
    }
    // Fim class Program
}
// Fim namespace ExemploControleFinanceiro