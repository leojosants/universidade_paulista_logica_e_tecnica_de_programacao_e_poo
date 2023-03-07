
namespace LacoDeRepeticaoFOREACH {
    
    class Program {

        static void Main(string[]args) {

           string[] Texto = new string[5];

            Texto[0] = "palavra 1";
            Texto[1] = "palavra 2";
            Texto[2] = "palavra 3";
            Texto[3] = "palavra 4";
            Texto[4] = "palavra 5";

            int i = 0;

            Console.WriteLine("");
            
            foreach (string s in Texto) {
                Console.WriteLine("Iteração: {0} - {1}", i, s);
                i++;
            }

            Console.WriteLine("\nPrograma finalizado!\n");

        }

    }

}