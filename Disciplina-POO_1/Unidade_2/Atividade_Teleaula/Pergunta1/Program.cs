
namespace Pergunta1
{

    class Program
    {

        static void Main(string[] args)
        {

            int numero = 7;

            bool numeroPar = numero % 2 == 0;
            bool menorQueCinco = numero < 5;

            if (numeroPar || menorQueCinco)
            {
                Console.WriteLine("O número é par e émenor que cinco!");
            }

            Console.ReadKey();

        }

    }

}
