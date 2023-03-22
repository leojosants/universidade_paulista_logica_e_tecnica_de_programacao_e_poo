namespace ColegioVencerSempre
{
    class Pessoa
    {
        private string nome = "";
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string sexo = "";
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Pessoa()
        {
            this.nome = "";
            this.idade = 0;
            this.sexo = "";
        }

        public Pessoa(string nome, int idade, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

    }   //  Fim class Pessoa


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Teste");

        }   //  Fim Main

    }   //  Fim class Program

}   //  namespace