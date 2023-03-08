// Início namespace ExemploMETODOS
namespace ExemploMETODOS
{

    // Início class Retangulo
    class Retangulo
    {
        // Atributos
        public double largura = 0;
        public double altura = 0;

        // Métodos
        public double CalculaArea()
        {
            return largura * altura;
        }

        public void AumentarLargura(double largura)
        {
            this.largura += largura;
        }
        public void AumentarAltura(double altura)
        {
            this.altura += altura;
        }
    }
    // Fim class Retangulo 

    // Início class Program
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();
            retangulo1.AumentarAltura(10);
            retangulo1.AumentarLargura(15);

            double area = retangulo1.CalculaArea();

            Console.WriteLine();
            Console.WriteLine("A área do retângulo de altura {0} e largura {1} vale {2}!", retangulo1.altura, retangulo1.largura, area);

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");

        }
    }
    // Fim class Program

}
// Fim namespace ExemploMETODOS