
namespace MeuTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            string str;

            Console.Write("Digite seu nome: ");
            str = Console.ReadLine();

            Console.Write("Digite uma letra: ");
            c = (char)Console.Read();
            Console.WriteLine();

            Console.WriteLine("Seu nome é: {0}", str);
            Console.WriteLine("A letra é: {0}", c.ToString());
            Console.ReadLine();
        }
    }
}

/*

    Métodos de interação de teclado e tela

        Método                  Descrição

        Console.Write           Escreve na tela, na posição onde está o cursor.
        Console.WriteLine       Escreve na tela e ao final salta uma linha, posicionando o cursor no início da nova linha.
        Console.Read            Lê a digitação de algo no teclado (aguarda até que uma tecla seja pressionada).
        Console.ReadLine        Lê a digitação do teclado e aguarda até que a tecla Enter seja digitada.

*/