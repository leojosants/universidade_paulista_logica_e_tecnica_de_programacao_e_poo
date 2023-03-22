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

        private bool livre;
        public bool Livre
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

        public static List<Equipamento> listaReservas = new List<Equipamento>();

        public Reservas(Colaborador colaborador, List<Equipamento> listaEquipamentos)
        {
            this.colaborador = colaborador;
            this.listaEquipamentos = listaEquipamentos;
        }

        public void ExibirReservas()
        {
            Console.WriteLine("\nReservas do usuário '{0}':", Colaborador.Nome);
            Console.WriteLine("| Total de reservas: {0}", listaReservas.Count());

            for (int i = 0; i < listaReservas.Count(); i++)
            {
                Console.Write("| Código:    {0}", listaReservas[i].Codigo);
                Console.WriteLine("\t|\t Nome:      {0}", listaReservas[i].Nome);
            }
        }

        public void ExibirRelaçãoEquipamentos()
        {
            Console.WriteLine("--> Relação de Equipamentos exibida pelo usuário '{0}':", Colaborador.Nome);

            foreach (var item in ListaEquipamentos)
            {
                Console.Write("| Código:    {0}\t", item.Codigo);
                Console.Write("|\t Livre:     {0}", item.Livre);
                Console.WriteLine("\t|\t Nome:      {0}", item.Nome);
            }

        }

        public void RealizarReserva(Equipamento equipamento)
        {
            if (equipamento.Livre == true)
            {
                listaReservas.Add(equipamento);

                equipamento.Livre = false;

                Console.WriteLine(" *Usuário '{0}' equipamento '{1}' reservado!", Colaborador.Nome, equipamento.Nome);
            }
            else
            {
                Console.WriteLine(" *Usuário '{0} equipamento '{1}' indisponível!", Colaborador.Nome, equipamento.Nome);
            }

            ExibirReservas();
        }

        public void FinalizarReserva(Equipamento equipamento)
        {
            if (listaReservas.Count() == 0)
            {
                Console.WriteLine(" *Usuário '{0}' não possui reserva!", Colaborador.Nome);
            }
            else if (!listaReservas.Contains(equipamento))
            {
                Console.WriteLine(" *Usuário '{0}', o equipamento {1} não consta nas suas reservas ou já foi desocupado!", Colaborador.Nome, equipamento.Nome);
            }
            else
            {
                listaReservas.Remove(equipamento);

                equipamento.Livre = true;

                Console.WriteLine(" *Usuário '{0}' desocupou o equipamento '{1}!", Colaborador.Nome, equipamento.Nome);
            }

            ExibirReservas();
        }

    }  //  Fim     class Reservas


    class Program
    {
        static void Main(string[] args)
        {

            ExibirTitulo();

            Colaborador colaboradorProfessor = new Colaborador();
            CriarColaboradorProfessor(colaboradorProfessor);

            Console.WriteLine("\nDados do colaborador '{0}':", colaboradorProfessor.Nome);
            Console.WriteLine(colaboradorProfessor);

            Colaborador colaboradorCoordenador = new Colaborador();
            CriarColaboradorCoordenador(colaboradorCoordenador);

            Console.WriteLine("\nDados do colaborador '{0}':", colaboradorCoordenador.Nome);
            Console.WriteLine(colaboradorCoordenador);

            List<Colaborador> listaColaboradores = new List<Colaborador>();
            listaColaboradores.Add(colaboradorProfessor);
            listaColaboradores.Add(colaboradorCoordenador);

            Console.WriteLine("\nRelação de Colaboradores:");
            ExibirListaColaboradores(listaColaboradores);

            Console.WriteLine();

            Equipamento c001 = new Equipamento();
            c001.Nome = "CABO VGA";
            c001.Codigo = "001";

            Equipamento c002 = new Equipamento();
            c002.Nome = "NOTEBOOK";
            c002.Codigo = "002";

            Equipamento c003 = new Equipamento();
            c003.Nome = "DATA-SHOW";
            c003.Codigo = "003";

            Equipamento c004 = new Equipamento();
            c004.Nome = "MOUSE USB";
            c004.Codigo = "004";

            Equipamento c005 = new Equipamento();
            c005.Nome = "CABO HDMI";
            c005.Codigo = "005";

            Equipamento c006 = new Equipamento();
            c006.Nome = "TV COM VCR";
            c006.Codigo = "006";

            Equipamento c007 = new Equipamento();
            c007.Nome = "MOUSE WIRELLES";
            c007.Codigo = "007";

            Equipamento c008 = new Equipamento();
            c008.Nome = "KIT MULTIMÍDIA";
            c008.Codigo = "008";

            Equipamento c009 = new Equipamento();
            c009.Nome = "PROJETOR DE SLIDE"; //17
            c009.Codigo = "009";

            Equipamento c010 = new Equipamento();
            c010.Nome = "SISTEMA DE AUDIO-MICROFONE";
            c010.Codigo = "010";

            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            listaEquipamentos.Add(c001);
            listaEquipamentos.Add(c002);
            listaEquipamentos.Add(c003);
            listaEquipamentos.Add(c004);
            listaEquipamentos.Add(c005);
            listaEquipamentos.Add(c006);
            listaEquipamentos.Add(c007);
            listaEquipamentos.Add(c008);
            listaEquipamentos.Add(c009);
            listaEquipamentos.Add(c010);

            Console.WriteLine("Relação de Equipamentos:");
            ExibirListaEquipamentos(listaEquipamentos);

            Reservas reservas01 = new Reservas(colaboradorCoordenador, listaEquipamentos);
            Reservas reservas02 = new Reservas(colaboradorProfessor, listaEquipamentos);

        }   //  Fim Main

        static void ExibirListaColaboradores(List<Colaborador> listaColaboradores)
        {
            foreach (var item in listaColaboradores)
            {
                Console.WriteLine(" - {0}", item.Nome);
            }
        }

        static void ExibirListaEquipamentos(List<Equipamento> listaEquipamentos)
        {
            foreach (var item in listaEquipamentos)
            {
                Console.Write(" | Código:    {0}\t", item.Codigo);
                Console.Write("|\t Livre:     {0}", item.Livre);
                Console.WriteLine("\t|\t Nome:      {0}", item.Nome);
            }
        }

        static void CriarColaboradorProfessor(Colaborador colaboradorProfessor)
        {
            colaboradorProfessor.Idade = "38";
            colaboradorProfessor.Senha = "1234";
            colaboradorProfessor.Sexo = "Masculino";
            colaboradorProfessor.Tipo = "Professor";
            colaboradorProfessor.Telefone = "032999445588";
            colaboradorProfessor.Nome = "Leonardo Professor";
            colaboradorProfessor.Email = "leonardo@professor.com";
        }

        static void CriarColaboradorCoordenador(Colaborador colaboradorCoordenador)
        {
            colaboradorCoordenador.Idade = "58";
            colaboradorCoordenador.Senha = "4321";
            colaboradorCoordenador.Sexo = "Masculino";
            colaboradorCoordenador.Tipo = "Coordenaddor";
            colaboradorCoordenador.Telefone = "032944556412";
            colaboradorCoordenador.Nome = "Leonardo Coordenador";
            colaboradorCoordenador.Email = "leonardo@coordenador.com";
        }

        static void ExibirTitulo()
        {
            Console.WriteLine("\nSISTEMA DE RESERVAS DE EQUIPAMENTOS - COLÉGIO VENCER");
        }

    }   //  Fim class Program

}   //  namespace