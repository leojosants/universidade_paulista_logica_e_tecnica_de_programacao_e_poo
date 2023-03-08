// Início namespace ExemploSOBREPOSICAO
namespace ExemploSOBREPOSICAO
{
    // Início class Empregado
    class Empregado
    {
        // Atributos
        public string nome;
        private double SalarioBase;

        // Construtor
        public Empregado(string nome, double SalarioBase)
        {
            this.nome = nome;
            this.SalarioBase = SalarioBase;
        }

        // Método
        public virtual double CalculaPagamento()
        {
            return SalarioBase;
        }
    }
    // Fim class Empregado


    // Início class Comissionado
    class Comissionado : Empregado
    {
        // Atributo
        private double comissao;

        // Construtor
        public Comissionado(string nome, double SalarioBase, double comissao)
            : base(nome, SalarioBase)
        {
            this.comissao = comissao;
        }

        // Sobrescrita
        public override double CalculaPagamento()
        {
            return base.CalculaPagamento() + comissao;
        }
    }
    // Fim class Comissionado

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Empregado empregado1 = new Empregado("Maria", 1000);
            Console.WriteLine("Nome: {0} | Cálculo: R${1}", empregado1.nome, empregado1.CalculaPagamento());

            Comissionado comissionado1 = new Comissionado("Paula", 1000, 500);
            Console.WriteLine("Nome: {0} | Cálculo: R${1}", comissionado1.nome, comissionado1.CalculaPagamento());

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
    // Fim class Program

}
// Fim namespace ExemploSOBREPOSICAO