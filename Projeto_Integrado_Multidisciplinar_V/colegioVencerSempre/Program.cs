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

        private string idade;
        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Pessoa()
        {
            this.nome = "";
            this.idade = "";
            this.sexo = "";
        }

        public Pessoa(string nome, string idade, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            return Nome + "" + idade + "" + sexo;
        }

    }   //  Fim class Pessoa


    class Colaborador : Pessoa
    {
        static Random numeroAleatorio = new Random();

        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telefone = "";
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string tipo = "";
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int registro;
        public int Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        public Colaborador()
        {
            this.email = "";
            this.telefone = "";
            this.tipo = "";
            this.registro = numeroAleatorio.Next(100, 500);
        }

        public Colaborador(string nome, string idade, string sexo, string email, string telefone, string tipo)
            : base(nome, idade, sexo)
        {
            this.email = email;
            this.telefone = telefone;
            this.tipo = tipo;
            this.registro = numeroAleatorio.Next(100, 500);
        }

    }   //  Fim class Colaborador


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nSISTEMA DE RESERVAS DE EQUIPAMENTOS - COLÉGIO VENCER");



        }   //  Fim Main

    }   //  Fim class Program

}   //  namespace