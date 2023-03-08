
// Início namespace ExemploPOLIMORFISMO
namespace ExemploPOLIMORFISMO
{

    // Início class Pessoas
    public class Pessoa
    {
        // Atributo
        private string nome;

        // Construtor
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        // Método
        public override string ToString()
        {
            return "\n Dados da Pessoa: \n Nome: " + nome;
        }
    }
    // Fim class Pessoas

    // Início class Cliente
    public class Cliente : Pessoa
    {
        // Atributo
        public double limiteDeCredito;

        // Construtor
        public Cliente(string nome, double limiteDeCredito)
            : base(nome)
        {
            // limiteDeCredito = limiteDeCredito;
            this.limiteDeCredito = limiteDeCredito;
        }
    }
    // Fim class Cliente

    // Início class Funcionario
    public class Funcionario : Pessoa
    {
        public float salario;

        // Construtor
        public Funcionario(string nome, float salario)
            : base(nome)
        {
            this.salario = salario;
        }

        // Método
        public override string ToString()
        {
            return "\n Funcionário: " + base.ToString() + "\n Salário: R$" + salario;
        }
    }
    // Fim class Funcionario

    // Início class Gerente
    class Gerente : Funcionario
    {
        // Atributo
        private string departamento;

        // Contrutor 
        public Gerente(string departamento, float salario, string nome)
            : base(nome, salario)
        {
            this.departamento = departamento;
        }
    }
    // Fimclass Gerente

    // Início class Banco
    public class Banco
    {
        // Método
        public static float ValorDoEmprestimo(Pessoa pessoa)
        {
            float valor;

            if (pessoa is Gerente)
            {
                valor = ((Gerente)pessoa).salario * 10;
            }
            else if (pessoa is Funcionario)
            {
                valor = ((Funcionario)pessoa).salario * 5;
            }
            else if (pessoa is Cliente)
            {
                valor = (float)((Cliente)pessoa).limiteDeCredito * 2;
            }
            else
            {
                valor = 0;
            }

            return valor;
        }
    }
    // Fim class Banco

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            // Teste 1 - Funcionário
            Funcionario funcionario1 = new Funcionario("João", 3000);
            Console.WriteLine(funcionario1.ToString() + "\n Emprestimo: R$" + Banco.ValorDoEmprestimo(funcionario1));

            // Teste 2 - Pessoa com funcionário
            Pessoa funcionario2 = new Funcionario("José", 4000);
            Console.WriteLine(funcionario2.ToString() + "\n Empréstimo: R$" + Banco.ValorDoEmprestimo(funcionario2));

            // Teste 3 - Gerente
            Gerente gerente1 = new Gerente("Contabilidade", 5000, "Marcos");
            Console.WriteLine(gerente1.ToString() + "\n Empréstimo: R$" + Banco.ValorDoEmprestimo(gerente1));

            // Teste 4 - Cliente
            Cliente cliente1 = new Cliente("Maria", 3500);
            Console.WriteLine(cliente1.ToString() + "\n Empréstimo: R$" + Banco.ValorDoEmprestimo(cliente1));

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
    // Fim class Program

}
// Fim namespace ExemploPOLIMORFISMO
