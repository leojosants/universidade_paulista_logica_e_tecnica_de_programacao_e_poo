// Início namespace ExemploCLASSEABSTRATA
namespace ExemploCLASSEABSTRATA
{

    // Início class FiguraGeometrica
    abstract class FiguraGeometrica
    {
        // Atributos
        public double largura = 0;
        public double altura = 0;

        // Método
        public abstract double CalculaArea();
    }
    // Fim class FiguraGeometrica

    // Início class Retangulo : FiguraGeometrica
    class Retangulo : FiguraGeometrica
    {
        // Método sobrescrito
        public override double CalculaArea() { return largura * altura; }
    }
    // Fim class Retangulo : FiguraGeometrica

    // Início class Triangulo : FiguraGeometrica
    class Triangulo : FiguraGeometrica
    {
        // Método sobrescrito
        public override double CalculaArea() { return (largura * altura) / 2; }
    }
    // Fim class Triangulo : FiguraGeometrica

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.largura = 8.3;
            r.altura = 3.5;
            Console.WriteLine("\n Área do Retângulo: {0}", r.CalculaArea());

            Triangulo t = new Triangulo();
            t.largura = 8.3;
            t.altura = 3.5;
            Console.WriteLine(" Área do Triângulo: {0}", t.CalculaArea());

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploCLASSEABSTRATA