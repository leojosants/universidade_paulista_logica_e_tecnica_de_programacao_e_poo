
namespace ExemploRobos
{

    class Robo
    {
        public short codigoIdentificacao;
        public String versao;
        public int dataCriacao;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robo r2d2 = new Robo();
            Robo c3po = new Robo();

            r2d2.codigoIdentificacao = 1234;
            r2d2.versao = "V1.0";

            c3po.versao = r2d2.versao;

            r2d2.dataCriacao = c3po.dataCriacao = 991201;

            c3po.codigoIdentificacao = 999;

            Console.WriteLine("\n - Robo R2D2 = Código: {0} | Versão: {1} | Criação: {2}", r2d2.codigoIdentificacao, r2d2.versao, r2d2.dataCriacao);
            Console.WriteLine(" - Robo C3PO = Código: {0}  | Versão: {1} | Criação: {2} \n", c3po.codigoIdentificacao, c3po.versao, c3po.dataCriacao);

        }

    }

}
