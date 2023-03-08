
namespace ExemploEncapsulamento
{
    class Conta
    {
        // Atributos
        private String nome;
        private double saldo;


        // Construtor
        public Conta(String nome)
        {
            this.nome = nome;
            this.saldo = 0;
        }

        // Método personalizado
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }

        // Getters e Setters
        public double Saldo
        {
            get { return saldo; }
        } /* public double GetSaldo() {return this.saldo;} */

        // Encapsulamento em C#
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        } /* public String GetNome() {return this.nome;} / public void SetNome(String nome) {this.nome = nome;} */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta ccJF = new Conta("");

            ccJF.Nome = "José Frederico";

            Console.WriteLine();
            Console.WriteLine("Nome: {0} | Saldo: R${1}", ccJF.Nome, ccJF.Saldo);

            ccJF.Depositar(500);
            Console.WriteLine("Nome: {0} | Saldo: R${1}", ccJF.Nome, ccJF.Saldo);

            // ccJF.saldo = 1000000;
            Console.WriteLine("Nome: {0} | Saldo: R${1}", ccJF.Nome, ccJF.Saldo);

            ccJF.Sacar(200000);
            Console.WriteLine("Nome: {0} | Saldo: R${1}", ccJF.Nome, ccJF.Saldo);

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
}



