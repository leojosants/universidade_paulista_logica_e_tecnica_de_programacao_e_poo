
namespace ListaEnumeradaLIST
{

    class Program
    {

        static void Main(string[] args)
        {

            // Instanciando uma LISTA
            List<int> lista = new List<int>();

            // Armazenando novos elementos
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            // Imprimindo a LISTA
            Console.WriteLine("\nElementos da LISTA:");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            // Acessando indice
            int j = lista[0];
            Console.WriteLine("\n - Elemento na posição 0: {0}\n", j);

            Console.WriteLine("----------/----------/----------");

            // Removendo conta por elemento ou indice
            lista.Remove(2);    // remove pelo elemento
            lista.RemoveAt(0);  // remove por indice

            // Imprimindo a LISTA
            Console.WriteLine("\nElementos da LISTA:");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            // Verificando a quantidade de elementos existente na LISTA
            int qtdElementos = lista.Count;
            Console.WriteLine("\n - Quantidade de elementos: {0}\n", qtdElementos);

            Console.WriteLine("----------/----------/----------");

            // Imprimindo a LISTA
            Console.WriteLine("\nElementos da LISTA:");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            // Verificando se um elemento está na LISTA
            bool temElemento1 = lista.Contains(1);
            bool temElemento3 = lista.Contains(3);
            Console.WriteLine(" - O elemento 1 está na LISTA? {0}", temElemento1);
            Console.WriteLine(" - O elemento 3 está na LISTA? {0}", temElemento3);

            Console.WriteLine("----------/----------/----------");


            Console.WriteLine("\n-- Fim do Programa --\n");

        }

    }

}