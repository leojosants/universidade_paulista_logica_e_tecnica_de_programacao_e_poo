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
            return " Nome:     " + Nome
                + "\n Sexo:     " + Sexo
                + "\n Idade:    " + Idade;
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

        private string senha = "";
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
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
            this.telefone = "";
            this.email = "";
            this.senha = "";
            this.tipo = "";
            this.registro = numeroAleatorio.Next(100, 500);
        }

        public Colaborador(string nome, string idade, string sexo, string telefone, string email, string senha, string tipo)
            : base(nome, idade, sexo)
        {
            this.telefone = telefone;
            this.email = email;
            this.senha = senha;
            this.tipo = tipo;
            this.registro = numeroAleatorio.Next(100, 500);
        }

        public override string ToString()
        {
            return base.ToString()
                + "\n Tipo:     " + this.Tipo
                + "\n Email:    " + this.Email
                + "\n Senha:    " + this.Senha
                + "\n Telefone: " + this.Telefone
                + "\n Registro: " + this.Registro;
        }

    }   //  Fim class Colaborador


    class Equipamento
    {
        private string nome = "";
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string codigo = "";
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected bool livre;
        private bool Livre
        {
            get { return livre; }
            set { livre = value; }
        }

        public Equipamento()
        {
            this.nome = "";
            this.codigo = "";
            this.livre = true;
        }

        public Equipamento(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.livre = true;
        }

    }   //  Fim class Equipamento


    class Reservas
    {
        private Colaborador colaborador;
        public Colaborador Colaborador
        {
            get { return colaborador; }
            set { colaborador = value; }
        }

        private List<Equipamento> listaEquipamentos;
        public List<Equipamento> ListaEquipamentos
        {
            get { return listaEquipamentos; }
            set { listaEquipamentos = value; }
        }

        public List<Equipamento> ListaReservas = new List<Equipamento>();

        public Reservas(Colaborador colaborador, List<Equipamento> listaEquipamentos)
        {
            this.colaborador = colaborador;
            this.listaEquipamentos = listaEquipamentos;
        }

    }  //  Fim     class Reservas


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nSISTEMA DE RESERVAS DE EQUIPAMENTOS - COLÉGIO VENCER");

            Colaborador usuarioProfessor = new Colaborador();
            usuarioProfessor.Idade = "38";
            usuarioProfessor.Senha = "1234";
            usuarioProfessor.Sexo = "Masculino";
            usuarioProfessor.Tipo = "Professor";
            usuarioProfessor.Telefone = "032999445588";
            usuarioProfessor.Nome = "Usuário Professor";
            usuarioProfessor.Email = "usuario@professor.com";

            Console.WriteLine();
            Console.WriteLine(usuarioProfessor);
            Console.WriteLine();

            Colaborador usuarioCoordenador = new Colaborador();
            usuarioCoordenador.Idade = "58";
            usuarioCoordenador.Senha = "4321";
            usuarioCoordenador.Sexo = "Masculino";
            usuarioCoordenador.Tipo = "Coordenaddor";
            usuarioCoordenador.Telefone = "032944556412";
            usuarioCoordenador.Nome = "Usuário Coordenador";
            usuarioCoordenador.Email = "usuario@coordenador.com";

            Console.WriteLine(usuarioCoordenador);
            Console.WriteLine();

            List<Colaborador> listaColaboradores = new List<Colaborador>();
            listaColaboradores.Add(usuarioProfessor);
            listaColaboradores.Add(usuarioCoordenador);

            Equipamento c01 = new Equipamento();
            c01.Nome = "CABO HDMI";
            c01.Codigo = "01";

            Equipamento c02 = new Equipamento();
            c02.Nome = "CABO VGA";
            c02.Codigo = "02";

            Equipamento c03 = new Equipamento();
            c03.Nome = "TV COM VCR";
            c03.Codigo = "03";

            Equipamento c04 = new Equipamento();
            c04.Nome = "PROJETOR DE SLIDE";
            c04.Codigo = "04";

            Equipamento c05 = new Equipamento();
            c05.Nome = "NOTEBOOK";
            c05.Codigo = "05";

            Equipamento c06 = new Equipamento();
            c06.Nome = "KIT MULTIMÍDIA";
            c06.Codigo = "06";

            Equipamento c07 = new Equipamento();
            c07.Nome = "DATA-SHOW";
            c07.Codigo = "07";

            Equipamento c08 = new Equipamento();
            c08.Nome = "SISTEMA DE AUDIO-MICROFONE";
            c08.Codigo = "08";

            Equipamento c09 = new Equipamento();
            c09.Nome = "MOUSE USB";
            c09.Codigo = "09";

            Equipamento c010 = new Equipamento();
            c010.Nome = "SISTEMA DE AUDIO-MICROFONE";
            c010.Codigo = "010";

            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            listaEquipamentos.Add(c01);
            listaEquipamentos.Add(c02);
            listaEquipamentos.Add(c03);
            listaEquipamentos.Add(c04);
            listaEquipamentos.Add(c05);
            listaEquipamentos.Add(c06);
            listaEquipamentos.Add(c07);
            listaEquipamentos.Add(c08);
            listaEquipamentos.Add(c09);
            listaEquipamentos.Add(c010);



        }   //  Fim Main

    }   //  Fim class Program

}   //  namespace