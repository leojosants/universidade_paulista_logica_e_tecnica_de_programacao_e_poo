
namespace ExemploMODIFICADORSTATIC
{
    public class Exemplo
    {
        // Atributos
        private static int seq = 0;
        public int nro;

        // Construtor
        public Exemplo()
        {
            nro = ++seq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exemplo e1 = new Exemplo();
            Console.WriteLine(e1.nro);

            Exemplo e2 = new Exemplo();
            Console.WriteLine(e2.nro);

            Exemplo e3 = new Exemplo();
            Console.WriteLine(e3.nro);

            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
    }
}