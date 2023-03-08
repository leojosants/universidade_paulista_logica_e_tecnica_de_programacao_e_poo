
namespace ExemploASSOCIACAO
{
    class Motor
    {
        // Atributos
        public int Cilindros;
        public double Capacidade;

        // Construtor
        public Motor(int cilindros, double capacidade)
        {
            this.Cilindros = cilindros;
            this.Capacidade = capacidade;
        }
    }

    class Carro
    {
        // Atributos
        public string cor;
        public Motor motor;

        // Construtor
        public Carro(String cor, Motor motor)
        {
            this.cor = cor;
            this.motor = motor;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Motor AP1000 = new Motor(4, 1.0);
            Motor AP1600 = new Motor(4, 1.6);

            Carro gol1000 = new Carro("Vermelho", AP1000);
            Carro fox1000 = new Carro("Preto", AP1000);
            Carro crosfox = new Carro("Amarelo", AP1600);

            Console.WriteLine();
            Console.WriteLine("Dados: {0}", crosfox.motor.Capacidade);
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
}