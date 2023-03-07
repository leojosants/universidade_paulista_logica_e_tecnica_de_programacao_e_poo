
namespace Matrizes {
    
    class Program {

        static void Main(string[] args) {

            // Criação de uma matriz de 5 posições de números inteiros
            int[] numeros = new int[5];
            int i = 0;

            // Guardando elementos nas posições
            numeros[0] = 1;
            numeros[1] = 600;
            numeros[2] = 257;
            numeros[3] = 12;
            numeros[4] = 42;

            Console.WriteLine("\nImpressão normal");
            Console.WriteLine("Posição 0: {0}", numeros[0]);
            Console.WriteLine("Posição 1: {0}", numeros[1]);
            Console.WriteLine("Posição 2: {0}", numeros[2]);
            Console.WriteLine("Posição 3: {0}", numeros[3]);
            Console.WriteLine("Posição 4: {0}", numeros[4]);

            Console.WriteLine("\nImpressão formatada");
            foreach(int n in numeros) {
                Console.WriteLine("Posição {0} - {1}", i, n);
                i++;
            }

            Console.WriteLine("\n----------/----------/----------\n");

            // Outra forma para ciração de array co pré preechimento dasppsições
            int[] umAoCinco = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Impressão normal");
            Console.WriteLine("Posição 0: {0}", umAoCinco[0]);
            Console.WriteLine("Posição 1: {0}", umAoCinco[1]);
            Console.WriteLine("Posição 2: {0}", umAoCinco[2]);
            Console.WriteLine("Posição 3: {0}", umAoCinco[3]);
            Console.WriteLine("Posição 4: {0}", umAoCinco[4]);
            
            Console.WriteLine("\nImpressão formatada");
            foreach(int n in numeros) {
                Console.WriteLine("Posição {0} - {1}", i, n);
                i++;
            }

            Console.WriteLine("\n - - Programa Finalizado - - \n");

        }

    }

}