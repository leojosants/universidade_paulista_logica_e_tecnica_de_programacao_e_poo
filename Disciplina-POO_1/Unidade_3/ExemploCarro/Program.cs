
namespace ExemploCarro
{

    class Carro
    {
        // Atributos
        public String marca;
        public String modelo;
        public String cor;
        public short ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            Carro doZe = new Carro();

            meuCarro.marca = "Volkswagen";
            meuCarro.modelo = "Fusca";
            meuCarro.cor = "Verde";
            meuCarro.ano = 1998;

            doZe.marca = "Gurgel";
            doZe.modelo = "BR500";
            doZe.cor = "Branco";
            doZe.ano = 1978;

            Console.WriteLine("\nMeu carro = Marca: {0} | Modelo: {1} | Cor: {2} | Ano: {2}", meuCarro.marca, meuCarro.modelo, meuCarro.cor, meuCarro.ano);
            Console.WriteLine("Carro do Zé = Marca: {0} | Modelo: {1} | Cor: {2} | Ano: {2}\n", doZe.marca, doZe.modelo, doZe.cor, doZe.ano);

        }

    }

}