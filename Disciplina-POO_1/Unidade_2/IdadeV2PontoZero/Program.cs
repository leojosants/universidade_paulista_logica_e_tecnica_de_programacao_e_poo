
namespace IdadeV2PontoZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, idadeNoFuturo, qtdAnos;

            idade = 0;
            qtdAnos = 0;

            Console.WriteLine();
            Console.WriteLine("Programa Idade versão 2.0");
            Console.WriteLine();

            Console.Write("Informe sua idade atual: ");

            idade = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine();
            Console.Write("Daqui a quantos anos você quer saber sua idade? ");

            qtdAnos = Convert.ToInt32(Console.ReadLine());
            idadeNoFuturo = idade + qtdAnos;

            Console.WriteLine("Hoje você tem {0} anos. Daqui a {1} anos você terá {2} anos de idade!", idade, qtdAnos, idadeNoFuturo);
            Console.WriteLine();

        }
    }
}

/*

    Padrões de valores de tipos de variáveis em C#
        T i p o            Conteúdo
            Boolean         False
            Byte            0
            Short           0
            Char            Null
            Int             0
            Float           0.0
            Long            0
            Double          0.0


    Operadores matemáticos em C#
        Símbolo     Operador matemático
            +           Adição
            -           Subtração
            *           Multiplicação
            /           Divisão
            %           Resto da divisão

*/