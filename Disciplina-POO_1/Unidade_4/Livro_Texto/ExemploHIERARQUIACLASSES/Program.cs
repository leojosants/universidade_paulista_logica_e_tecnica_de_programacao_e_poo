// Início namespace ExemploHIERARQUIACLASSES
namespace ExemploHIERARQUIACLASSES
{

    // Início class Ponto
    class Ponto
    {
        // Atributo;
        public int x;
        public int y;

        // Construtor
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /*
            Método sobrescrito Equals(), ele recebe como parâmentro um objeto do tipo object e dentro dele é utilizado o método GetType() para obter o tipo da instância corrente
        */
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) { return false; }

            Ponto other = (Ponto)obj;

            return (this.x == other.x) && (this.y == other.y);
        }

        /*
            Método sobrescrito GetHashCode(), é feita uma simulação do cálculo de um Hash particular para caracterizar o objeto
        */
        // public override int GetHashCode() { return x ^ y; }

        /*
            Método sobrescrito, o ToString, mostra o caminho da herança do objeto.
        */
        // public override string ToString() { return String.Format("({0}, {1})", x, y); }

        /*
            Método Copy, que utiliza o método memberWiseClone(), e este cria uma nova instância do objeto corrente
        */
        public Ponto Copy() { return (Ponto)this.MemberwiseClone(); }
    }
    // Fim class Ponto

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Ponto ponto1 = new Ponto(1, 2);
            Ponto ponto2 = ponto1.Copy();
            Ponto ponto3 = ponto1;

            Console.WriteLine();

            /*  
                Verificando com o método ReferenceEquals() se são dois objetos ou apenas um mesmo objeto com duas referências diferentes apontando para ele 
            */
            if (Object.ReferenceEquals(ponto1, ponto2))
            {
                Console.WriteLine("As referências são IGUAIS!");
            }
            else
            {
                Console.WriteLine("As referências são DIFERENTES!");
            }

            // verificando se os dois objetos são iguais utilizando o método sobrescrito Equals():
            if (Object.Equals(ponto1, ponto2))
            {
                Console.WriteLine("Os Objetos são IGUAIS!");
            }
            else
            {
                Console.WriteLine("As Objetos são DIFERENTES!");
            }

            /*  
               Verificando com o método ReferenceEquals() se são dois objetos ou apenas um mesmo objeto com duas referências diferentes apontando para ele 
           */
            if (Object.ReferenceEquals(ponto1, ponto3))
            {
                Console.WriteLine("As referências são IGUAIS!");
            }
            else
            {
                Console.WriteLine("As referências são DIFERENTES!");
            }

            // Método sobrescrito sem estar comentado --> public override int GetHashCode() { return x ^ y; }
            Console.WriteLine("O Hashcode ponto1 é {0}", ponto1.GetHashCode());

            // Método sobrescrito comentado --> public override int GetHashCode() { return x ^ y; }
            Console.WriteLine("O Hashcode ponto1 é {0}", ponto1.GetHashCode());

            Console.WriteLine("Os valores de ponto1 são: {0}", ponto1);

            // Método comentado --> public override string ToString() { return String.Format("({0}, {1})", x, y); }
            Console.WriteLine("A String que representa ponto1' é: {0}", ponto1);

            Console.WriteLine("\n Pressione QUALQUER TECLA para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploHIERARQUIACLASSES