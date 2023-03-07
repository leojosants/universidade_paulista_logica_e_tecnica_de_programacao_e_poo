
namespace ProgramaTexto
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string c, c1, d, d1;

            Console.Write("\nDigite a primeira palavra: ");
            c = Console.ReadLine();

            Console.Write("Digite a segunda palavra: ");
            c1 = Console.ReadLine();

            Console.Write("\n - O tamanho da palavra {0} é: {1} \n", c, c.Length);
            Console.Write(" - Concatenando sem armazenar: {0} \n", c + c1);

            d = c;

            Console.Write(" - Conteúdo de d: {0} \n", d);

            d1 = c + c1;

            Console.Write(" - Concatenação d1: {0} \n", d1);
            Console.Write(" - Primeiro caracter da variável {0}: {1} \n", c, c.Substring(0, 1));
            Console.Write(" - Último caracter da variável {0}: {1} \n", c1, c1.Substring(c1.Length - 1, 1));
            Console.Write(" - Todos os caracteres, menos o primeiro caracter da variável {0}: {1} \n", d1, d1.Substring(1));
            Console.Write(" - O terceiro elemento da variável {0}: {1} \n", c, c.Substring(4, 1));
            Console.Write(" - Os três primeiros elementos da variável {0}: {1} \n", c, c.Substring(0, 3));
            Console.Write(" - Os três últimos elementos da variável {0}: {1} \n", c1, c1.Substring(c1.Length - 3, 3));

            Console.WriteLine();
        }
    }
}

/*

    Métodos de manipulação de dados do tipo texto (string)
        Função                                      Descrição
            Substring(posição_inicial,tamanho)          Este método retorna um pedaço do texto (substring) contido na variável (ou atributo) do tipo string.
                                                        A substring começa em uma posição de caractere especificada (posição_inicial) e tem um comprimento
                                                        especificado (tamanho), lembrando que a primeira posição da string (primeiro caractere do texto) é
                                                        indicada como posição 0.
            
            Length                                      Esta propriedade (atributo) contém o número de caracteres – ou seja, 
                                                        o tamanho – do texto (string) atual.

*/