
// Início namespace ExemploINTERFACE
namespace ExemploINTERFACE
{

    // Início interface iControleRemoto
    public interface iControleRemoto
    {
        // Método
        void ligar();
        void desligar();
        void aumentarVolume();
        void diminuirVolume();
        void avancar();
        void retroceder();
    }
    // Fim interface iControleRemoto

    // Início class Televisao
    public class Televisao : iControleRemoto
    {
        // Atributos
        private string marca;
        private string modelo;
        private bool ligada;
        private int nivelVolume;
        private int canal;

        // Construtor
        public Televisao(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            ligada = false;
            canal = 0;
        }

        // Implementações obrigatórias da interface 
        public virtual void ligar() { ligada = true; }
        public virtual void desligar() { ligada = false; }
        public virtual void aumentarVolume() { nivelVolume++; }
        public virtual void diminuirVolume() { nivelVolume--; }
        public virtual void avancar() { canal++; }
        public virtual void retroceder() { canal--; }

        // Exibindo dados
        public override string ToString()
        {
            string estado = ligada ? "ligada" : "deligada";
            return "Televisão " + "\n - Marca: " + marca + "\n - Modelo: " + modelo + "\n - Estado: " + estado;
        }
    }
    //  Fim class Televisao

    // Início class DVDPlayer
    public class DVDPlayer : iControleRemoto
    {
        // Atributos
        private string marca;
        private string modelo;
        private bool ligado;
        private bool open;
        private int capitulo;

        // Construtor
        public DVDPlayer(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            ligado = false;
            capitulo = 1;
        }

        // Implementações obrigatórias da interface 
        public virtual void ligar() { ligado = true; }
        public virtual void desligar() { ligado = false; }
        public virtual void aumentarVolume() { open = true; }
        public virtual void diminuirVolume() { open = false; }
        public virtual void avancar() { capitulo++; }
        public virtual void retroceder() { capitulo--; }

        // Exibição dos dados
        public override string ToString()
        {
            string estado = ligado ? "ligado" : "desligado";
            string combo = open ? "combo aberto" : "combo fechado";

            return " DVDPlayer \n - Marca: " + marca
                + "\n - Modelo: " + modelo
                + "\n - Estado: " + estado
                + "\n - Bandeja: " + combo
                + "\n - Capítulo: " + capitulo;
        }
    }
    // Fim class DVDPlayer

    // Início class Abajur
    class Abajur : iControleRemoto
    {
        // Atributos
        private bool chave;

        // Método
        internal Abajur() { chave = false; }

        // Implementações obrigatórias da interface 
        void iControleRemoto.aumentarVolume() { }
        void iControleRemoto.diminuirVolume() { }
        void iControleRemoto.avancar() { }
        void iControleRemoto.retroceder() { }
        void iControleRemoto.ligar() { chave = true; }
        void iControleRemoto.desligar() { chave = false; }

        // Exibindo dados
        public override string ToString() { return "Abajur - " + (chave ? "Aceso" : "Apagado"); }
    }
    // Fim class Abajur

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            iControleRemoto philco = new Televisao("Philco", "MultiVision");
            iControleRemoto dvdGradiente = new DVDPlayer("Gradiente", "D22");

            philco.ligar();
            dvdGradiente.ligar();

            Console.WriteLine();
            Console.WriteLine("Aparelhos iniciais:");
            Console.WriteLine(philco);
            
            Console.WriteLine();
            Console.WriteLine(dvdGradiente);

            philco.desligar();
            ((DVDPlayer)dvdGradiente).aumentarVolume();

            Console.WriteLine();
            Console.WriteLine("Aparelhos após desligar a TV e abrir o combo do DVD:");
            Console.WriteLine(philco);
            Console.WriteLine();
            Console.WriteLine(dvdGradiente);

            iControleRemoto alibaba = new Abajur();
            alibaba.ligar();
            Console.WriteLine();
            Console.WriteLine(alibaba);

            philco.desligar();
            Console.WriteLine();
            Console.WriteLine(philco);

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploINTERFACE