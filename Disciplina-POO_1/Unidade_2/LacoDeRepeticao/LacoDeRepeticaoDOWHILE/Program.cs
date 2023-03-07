
namespace LacoDeRepeticaoDOWHILE {
    
    class Program {

        static void Main(string[]args) {

            Console.WriteLine("");

            int i = 1;

            do {
                Console.WriteLine("Iteração: {0}", i);
                i++;
            } while (i < 10);

            Console.WriteLine("\nPrograma finalizado!\n");

        }

    }

}