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

    // Início interface IAquecedor
    interface IAquecedor
    {
        // Método
        void LigarAquecedor();
        void DesligarAquecedor();
    }
    // Fim interface IAquecedor

    // Início class Luminaria : IEletroportatil
    class Luminaria : Eletroportatil, IEletroportatil
    {
        // Implementando métodos obrigatórios da interface
        public void ligar()
        {
            ligado = true;
            Console.WriteLine("A luminária foi ligada!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine("A luminária foi desligada!");
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
            Console.WriteLine("O ventilador foi ligado!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine("O ventilador foi desligado!");
        }
    }
    // Fim class Ventilador : IEletroportatil

    // Início class VentiladorAquecedor : Eletroportatil, IEletroportatil, IAquecedor
    class VentiladorAquecedor : Eletroportatil, IEletroportatil, IAquecedor
    {
        // Atributos;
        private bool aquecedorLigado;

        // Implementando métodos obrigatórios da interface
        public void ligar()
        {
            ligado = true;
            Console.WriteLine("O aquecedor foi ligado!");
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine("O aquecedor foi desligado!");
        }

        // Implementando métodos obrigatórios da interface
        public void LigarAquecedor()
        {
            aquecedorLigado = true;
            Console.WriteLine("O ar quente foi ligado!");
        }
        public void DesligarAquecedor()
        {
            aquecedorLigado = false;
            Console.WriteLine("O ar quente foi desligado!");
        }
    }
    // Fim class VentiladorAquecedor : Eletroportatil, IEletroportatil, IAquecedor

    // Início class Eletroportatil
    class Eletroportatil
    {
        // Atributos
        protected bool ligado;

        // Método personalizado
        public void ExibirEstado()
        {
            if (ligado) { Console.WriteLine("Aparelho está ligado!"); }
            else { Console.WriteLine("Aparelho está desligado!"); }
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
            VentiladorAquecedor va = new VentiladorAquecedor();

            Console.WriteLine();

            Console.WriteLine("Ventilador aquecedor:");
            va.ExibirEstado();
            va.ligar();
            va.LigarAquecedor();
            va.ExibirEstado();

            Console.WriteLine("\nLuminária:");
            l.ExibirEstado();
            l.ligar();
            l.ExibirEstado();
            l.desligar();
            l.ExibirEstado();

            Console.WriteLine("\nVentilador:");
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