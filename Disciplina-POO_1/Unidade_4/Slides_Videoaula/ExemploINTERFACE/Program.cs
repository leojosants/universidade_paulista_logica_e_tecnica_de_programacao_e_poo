// Início namespace ExemploINTERFACE
namespace ExemploINTERFACE
{

    // Início interface IEletroportatil
    interface IEletroportatil
    {
        void ligar();
        void desligar();
    }
    // Fim interface IEletroportatil

    // Início class Luminaria : IEletroportatil
    class Luminaria : IEletroportatil
    {
        // Implementando métodos obrigatórios da interface
        public void ligar() { Console.WriteLine("A LUMINÁRIA foi ligada!"); }
        public void desligar() { Console.WriteLine("A LUMINÁRIA foi desligada!"); }
    }
    // Fim class Luminaria : IEletroportatil

    // Início class Ventilador : IEletroportatil
    class Ventilador : IEletroportatil
    {
        // Implementando métodos obrigatórios da interface
        public void ligar() { Console.WriteLine("A VENTILADOR foi ligado!"); }
        public void desligar() { Console.WriteLine("A VENTILADOR foi desligado!"); }
    }
    // Fim class Ventilador : IEletroportatil

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Luminaria l = new Luminaria();
            Ventilador v = new Ventilador();

            Console.WriteLine();

            l.ligar();

            v.ligar();

            l.desligar();

            v.desligar();

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploINTERFACE