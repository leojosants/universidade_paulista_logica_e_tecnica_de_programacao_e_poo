namespace DesvioCondicional
{
    class Program 
    {
        static void Main(string[] args)
        {
            double numero = 0;

            Console.Write("\nDigite um número: ");

            numero = double.Parse(Console.ReadLine());

            if(numero > 20) {
                Console.WriteLine("A metade de {0} é: {1}", numero, (numero / 2));
            }

            Console.WriteLine();
        }
    }
}
