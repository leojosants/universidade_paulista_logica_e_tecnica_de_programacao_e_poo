// Início namespace ExemploCLASSEABSTRATA
namespace ExemploCLASSEABSTRATA
{

    // Início class Botao
    abstract class Botao
    {
        // Atributo
        protected string rotulo;

        // Atributo e get - (estado)
        private bool estado;
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Metodo abstrato
        abstract public void Click();

        // Método concreto
        public void MostraBotao()
        {
            if (this.estado)
            {
                Console.WriteLine("Botão {0} ATIVO!", this.rotulo);
            }
            else
            {
                Console.WriteLine("Botão {0} INATIVO!", this.rotulo);
            }
        }
    }
    // Fim class Botao

    // Início class OK
    class OK : Botao
    {
        // Método
        public OK()
        {
            base.rotulo = "OK";
            Estado = true;
        }

        // Sobrescrito
        public override void Click()
        {
            if (Estado)
            {
                Console.WriteLine("\n CALCULANDO...");
            }
        }
    }
    // Fim class OK

    // Início class Cancela
    class Cancela : Botao
    {
        // Metodo
        public Cancela()
        {
            base.rotulo = "CANCELAR";
            Estado = false;
        }

        // Sobrescrita
        public override void Click()
        {
            if(Estado){
                Console.WriteLine("\n CANCELANDO...");
            }
        }
    }
    // Fim class Cancela

    // Início class Program
    class Program
    {
        // Início Main
        static void Main(string[] args)
        {
            Botao ok = new OK();
            ok.Click();

            Botao cancela = new Cancela();
            cancela.Click();
            cancela.MostraBotao();
            cancela.Estado = true;
            cancela.MostraBotao();
            cancela.Click();

            Console.WriteLine("\n Pressione ENTER para finalizar o programa!");
            Console.ReadKey();
            Console.WriteLine("\n -- Fim do Programa -- \n");
        }
        // Fim Main
    }
    // Fim class Program

}
// Fim namespace ExemploCLASSEABSTRATA
