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
    class Luminaria : Eletroportatil, IEletroportatil
    {
        // Implementando métodos obrigatórios da interface
        public void ligar()
        {
            ligado = true;
            Console.WriteLine(" A LUMINÁRIA foi ligada!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine(" A LUMINÁRIA foi desligada!");
        }
    }
    // Fim class Luminaria : IEletroportatil

    // Início class Ventilador : IEletroportatil
    class Ventilador : Eletroportatil, IEletroportatil
    {
        // Implementando métodos obrigatórios da interface
        public void ligar()
        {
            ligado = true;
            Console.WriteLine(" O VENTILADOR foi ligado!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine(" O VENTILADOR foi desligado!");
        }
    }
    // Fim class Ventilador : IEletroportatil

    // Início class Eletroportatil
    class Eletroportatil
    {
        // Atributos
        protected bool ligado;

        // Método personalizado
        public void ExibirEstado()
        {
            if (ligado) { Console.WriteLine(" Aparelho está ligado!"); }
            else { Console.WriteLine(" Aparelho está desligado!"); }
        }
    }
    // Fim class Eletroportatil

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Luminaria l = new Luminaria();
            Ventilador v = new Ventilador();

            Console.WriteLine();

            Console.WriteLine(" Luminária:");
            l.ExibirEstado();
            l.ligar();
            l.ExibirEstado();
            l.desligar();
            l.ExibirEstado();

            Console.WriteLine("\n Ventilador:");
            v.ExibirEstado();
            v.ligar();
            v.ExibirEstado();
            v.desligar();
            v.ExibirEstado();

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program
}
// Fim namespace ExemploINTERFACE