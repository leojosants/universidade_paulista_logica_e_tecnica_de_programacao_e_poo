// Início namespace ExemploHERANCAMULTIPLA
namespace ExemploHERANCAMULTIPLA
{

    // Início interface IVoador
    public interface IVoador
    {
        // Método
        void Voar();
    }
    // Fim interface IVoador

    // Início interface INavegador
    public interface INavegador
    {
        // Método
        void Navegar();
    }
    // Fim interface INavegador

    // Início class Aviao : IVoador
    public class Aviao : IVoador
    {
        // Método
        public void Voar()
        {
            Console.WriteLine("O avião voa!");
        }
    }
    // Fim class Aviao : IVoador

    // Início class HidroAviao : IVoador, INavegador - MULTIPLA HERANCA
    public class HidroAviao : IVoador, INavegador
    {
        // Método
        public void Voar(){
            Console.WriteLine("O Hidroavião voa!");
        }

        // Método
        public void Navegar(){
            Console.WriteLine("O Hidroavião navega!");
        }
    }
    // Fim class HidroAviao : IVoador, INavegador - MULTIPLA HERANCA

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            IVoador boeing = new Aviao();
            boeing.Voar();

            HidroAviao catalina = new HidroAviao();
            catalina.Voar();
            catalina.Navegar();

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploHERANCAMULTIPLA