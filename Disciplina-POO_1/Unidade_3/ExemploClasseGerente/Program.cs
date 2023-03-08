
namespace ExemploClasseGerente
{
    class Gerete
    {
        // Atributos
        public String nome;
        public double salario;

        // Método sem construtor
        public void AumentarSalario()
        {
            this.AumentarSalario(0.1);
        }

        // Método sem construtor
        public void AumentarSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gerete g = new Gerete();

            g.salario = 1000;

            Console.WriteLine();
            Console.WriteLine("Salário: R$" + g.salario);

            Console.WriteLine();
            Console.WriteLine("Aumentando o salário em 10%");
            g.AumentarSalario();
            Console.WriteLine("Salário R$" + g.salario);

            Console.WriteLine();
            Console.WriteLine("Aumentando o salário em 30%");
            g.AumentarSalario(0.3);
            Console.WriteLine("Salário R$" + g.salario);

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
}



