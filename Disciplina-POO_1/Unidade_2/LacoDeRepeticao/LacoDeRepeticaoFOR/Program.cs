
namespace LacoDeRepeticaoFOR {
    
    class Program {

        static void Main(string[]args) {

            Console.WriteLine();

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Iteração: {0}", i);
            }

            Console.WriteLine("----------/----------/----------");

            for (int i = 0; i < 5; i++) {

                if (i == 3) {
                    break;
                }

                Console.WriteLine("Iteração: {0}", i);
            }

            Console.WriteLine("----------/----------/----------");

            for (int i = 0; i < 5; i++) {

                if (i == 3) {
                    continue;
                }

                Console.WriteLine("Iteração: {0}", i);
            }

            Console.WriteLine("\nPrograma finalizado!\n");

        }

    }

}