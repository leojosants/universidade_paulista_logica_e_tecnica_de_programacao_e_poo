
namespace MinhaPrimeiraClasse
{

    class Conta
    {
        public double saldo;
        public double limite;
        public int conta;
    }

    // class categoria

    // class TipoPagamento

    // class Caixa

    class Program
    {
        static void Main(string[] args)
        {
            Conta referencia;

            referencia = new Conta();
            referencia.saldo = 1000.0;
            referencia.limite = 300;
            referencia.conta = 123;

        }

    }

}
