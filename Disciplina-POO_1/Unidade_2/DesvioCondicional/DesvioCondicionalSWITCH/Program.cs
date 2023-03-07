
namespace DesvioCondicionalSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c = 0;

            Console.Write("\nDigite um número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n- Opção 1: Verificar se o primeiro número é maior que o segundo número.");
            Console.WriteLine("- Opção 2: Verificar se o segundo número é maior que o primeiro número.");
            Console.WriteLine("- Opção 3: Verificar se os números são iguais.");

            Console.Write("\nO que deseja fazer com esses números? ");
            c = Int32.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    if (a > b) {
                        Console.WriteLine("O primeiro número é maior que o segundo número!");
                    }
                    else {
                        Console.WriteLine("O primeiro número não é maior que o segundo número!");
                    }
                    break;

                case 2:
                    if (a < b) {
                        Console.WriteLine("O segundo número é maior que o primeiro número!");
                    }
                    else {
                        Console.WriteLine("O segundo número não é maior que o primeiro número!");
                    }
                    break;

                case 3:
                    if (a == b) {
                        Console.WriteLine("Os dois número são iguais!");
                    }
                    else {
                        Console.WriteLine("Os dois números não são iguais!");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida, programa finalizado!");
                    break;
            }

            Console.WriteLine("\nPrograma finalizado!");

            Console.WriteLine();
        }
    }
}
