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

        public Pessoa()
        {
            this.nome = "";
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return " Nome:     " + Nome;
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
            this.email = "";
            this.senha = "";
            this.tipo = "";
            this.registro = numeroAleatorio.Next(100, 500);
        }

        public Colaborador(string nome, string email, string senha, string tipo)
            : base(nome)
        {
            this.email = email;
            this.senha = senha;
            this.tipo = tipo;
            this.registro = numeroAleatorio.Next(100, 500);
        }

        public string RecuperarSenha(string novaSenha)
        {
            return this.Senha = novaSenha;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\n Tipo:     " + this.Tipo
                + "\n Email:    " + this.Email
                + "\n Senha:    " + this.Senha
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

        private int dia;
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        private int mes;
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        private int ano;
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Equipamento()
        {
            this.nome = "";
            this.codigo = "";
        }

        public Equipamento(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.dia = 00;
            this.mes = 00;
            this.ano = 00;
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

        private static List<Equipamento> listaMinhasReservas = new List<Equipamento>();
        public List<Equipamento> ListaMinhasReservas
        {
            get { return listaMinhasReservas; }
            set { listaMinhasReservas = value; }
        }

        public Reservas(Colaborador colaborador, List<Equipamento> listaEquipamentos)
        {
            this.colaborador = colaborador;
            this.listaEquipamentos = listaEquipamentos;
        }

        public void ExibirReservas()
        {
            Console.WriteLine("\nReservas do usuário '{0}':", Colaborador.Nome);
            Console.WriteLine("| Total de reservas: {0}", listaMinhasReservas.Count());

            for (int i = 0; i < listaMinhasReservas.Count(); i++)
            {
                Console.Write("| Código:    {0}", listaMinhasReservas[i].Codigo);
                Console.Write("\t|\t Nome:      {0}", listaMinhasReservas[i].Nome);
                Console.WriteLine("\t|\tData para reserva: {0}/{1}/{2}", listaMinhasReservas[i].Dia, listaMinhasReservas[i].Mes, listaMinhasReservas[i].Ano);
            }
        }

        public void ExibirRelaçãoEquipamentos()
        {
            Console.WriteLine("--> Relação de Equipamentos:");

            if (listaEquipamentos.Count() == 0)
            {
                Console.WriteLine(" *Nenhum equipamento disponível para reserva!");
            }

            foreach (var item in listaEquipamentos)
            {
                Console.Write("| Código:    {0}", item.Codigo);
                Console.WriteLine("\t|\t Nome:      {0}", item.Nome);
            }

        }

        public void RealizarReserva(Equipamento equipamento)
        {
            listaMinhasReservas.Add(equipamento);
            listaEquipamentos.Remove(equipamento);

            Console.WriteLine("\n *O usuário '{0}' RESERVOU o equipamento '{1}' para o dia: '{2}/{3}/{4}'!\n", Colaborador.Nome, equipamento.Nome, equipamento.Dia, equipamento.Mes, equipamento.Ano);

            ExibirRelaçãoEquipamentos();
        }

        public void FinalizarReserva(Equipamento equipamento)
        {
            if (listaMinhasReservas.Count() == 0)
            {
                Console.WriteLine(" *Usuário '{0}' não possui reserva(s!\n", Colaborador.Nome);
            }
            else
            {
                listaMinhasReservas.Remove(equipamento);

                Console.WriteLine(" *Usuário '{0}' desocupou o equipamento '{1}!\n", Colaborador.Nome, equipamento.Nome);

                ListaEquipamentos.Add(equipamento);
            }

            ExibirRelaçãoEquipamentos();
        }

    }  //  Fim     class Reservas


    class Program
    {
        static void Main(string[] args)
        {

            string? respostaFinalizarReserva = "";
            string? infoEmailRecuperacao = "";
            string? respostaCadastro = "";
            string? respostaInicial = "";
            string? opcaoReservas = "";
            string? codigoRealizarReserva = "";
            string? codigoFinalizarReserva = "";
            string? novaSenha = "";
            string? nome = "";
            string? senha = "";
            string? email = "";
            string? testeSenhaLogin;
            int testeRegistroLogin;
            int diaReserva;
            int mesReserva;
            int anoReserva;
            int enviandoCodigoRecuperacaoSenha = 0;
            bool cadastrado = false;

            Random criarNumeroAleatorio = new Random();
            int codigoRecuperacaoSenhaRecebido = criarNumeroAleatorio.Next(1, 100);

            Colaborador colaborador = new Colaborador();
            List<Colaborador> listaColaboradores = new List<Colaborador>();

            Equipamento c001 = new Equipamento();
            c001.Nome = "CABO VGA";
            c001.Codigo = "c001";

            Equipamento c002 = new Equipamento();
            c002.Nome = "NOTEBOOK";
            c002.Codigo = "c002";

            Equipamento c003 = new Equipamento();
            c003.Nome = "DATA-SHOW";
            c003.Codigo = "c003";

            Equipamento c004 = new Equipamento();
            c004.Nome = "MOUSE USB";
            c004.Codigo = "c004";

            Equipamento c005 = new Equipamento();
            c005.Nome = "CABO HDMI";
            c005.Codigo = "c005";

            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            listaEquipamentos.Add(c001);
            listaEquipamentos.Add(c002);
            listaEquipamentos.Add(c003);
            listaEquipamentos.Add(c004);
            listaEquipamentos.Add(c005);

            do
            {
                ExibirMenuInicial();    //

                Console.Write("Escolha uma opção: ");
                respostaInicial = Console.ReadLine();
                try
                {
                    switch (respostaInicial)
                    {
                        case "1":   //  ENTRAR
                            Console.Write(" \nInforme o número de registro do usuário: ");
                            testeRegistroLogin = Convert.ToInt32(Console.ReadLine());

                            if (colaborador.Registro == testeRegistroLogin)
                            {
                                do
                                {
                                    Console.Write("Informe a senha  do usuário: ");
                                    testeSenhaLogin = Console.ReadLine();

                                } while (testeSenhaLogin == "");

                                if (colaborador.Senha != testeSenhaLogin)
                                {
                                    Console.WriteLine(" *Senha inválida!");
                                }
                                else if (colaborador.Senha == testeSenhaLogin)
                                {
                                    Console.WriteLine(" *Senha válida, direcionando para login...");

                                    Reservas reservas = new Reservas(colaborador, listaEquipamentos);

                                    Console.WriteLine("\nÁREA DE RESERVAS");

                                    do
                                    {
                                        ExibirMenuAreaReservas();

                                        Console.Write("Escolha uma opção: ");
                                        opcaoReservas = Console.ReadLine();

                                        switch (opcaoReservas)
                                        {
                                            case "1":

                                                Console.WriteLine("\nFAZER RESERVA");

                                                reservas.ExibirRelaçãoEquipamentos();

                                                if (reservas.ListaEquipamentos.Count() == 0)
                                                {
                                                    Console.WriteLine("\n *Todos equipamentos estão ocupados!");
                                                }
                                                else
                                                {
                                                    Console.Write("\n Informe a dia da reserva [xx]: ");
                                                    diaReserva = Convert.ToInt32(Console.ReadLine());

                                                    for (int i = 0; i < reservas.ListaEquipamentos.Count(); i++)
                                                    {
                                                        reservas.ListaEquipamentos[i].Dia = diaReserva;
                                                    }

                                                    Console.Write(" Informe o mês da reserva [xx]: ");
                                                    mesReserva = Convert.ToInt32(Console.ReadLine());

                                                    for (int i = 0; i < reservas.ListaEquipamentos.Count(); i++)
                                                    {
                                                        reservas.ListaEquipamentos[i].Mes = mesReserva;
                                                    }

                                                    Console.Write(" Informe o ano da reserva [xx]: ");
                                                    anoReserva = Convert.ToInt32(Console.ReadLine());

                                                    for (int i = 0; i < reservas.ListaEquipamentos.Count(); i++)
                                                    {
                                                        reservas.ListaEquipamentos[i].Ano = anoReserva;
                                                    }

                                                    Console.Write("\n Informe o código do equipamento: ");
                                                    codigoRealizarReserva = Console.ReadLine();

                                                    for (int i = 0; i < reservas.ListaEquipamentos.Count(); i++)
                                                    {
                                                        if (reservas.ListaEquipamentos[i].Codigo == codigoRealizarReserva)
                                                        {
                                                            reservas.RealizarReserva(reservas.ListaEquipamentos[i]);
                                                        }
                                                    }
                                                }
                                                break;

                                            case "2":
                                                reservas.ExibirReservas();

                                                if (reservas.ListaMinhasReservas.Count() != 0)
                                                {
                                                    do
                                                    {
                                                        Console.Write("\n Deseja finalizar alguma reserva [S/N]? ");
                                                        respostaFinalizarReserva = Console.ReadLine().ToUpper();

                                                    } while (respostaFinalizarReserva == "");

                                                    if (respostaFinalizarReserva == "S")
                                                    {
                                                        Console.Write("\n Informe o código do equipamento: ");
                                                        codigoFinalizarReserva = Console.ReadLine();

                                                        for (int i = 0; i < reservas.ListaMinhasReservas.Count(); i++)
                                                        {
                                                            if (reservas.ListaMinhasReservas[i].Codigo == codigoFinalizarReserva)
                                                            {
                                                                reservas.FinalizarReserva(reservas.ListaMinhasReservas[i]);
                                                            }
                                                        }
                                                    }
                                                }

                                                break;
                                        }

                                    } while (opcaoReservas != "3");

                                }
                            }
                            else
                            {
                                Console.WriteLine(" *Resgistro inexistente, favor realizar cadastrado!");

                                // CADASTRO

                                Console.WriteLine("\nCADASTRO DE USUÁRIOS");

                                CriarColaborador(colaborador, listaColaboradores, cadastrado, nome, senha, email);

                                do
                                {
                                    Console.Write("\n *Confirmar cadastro [S/N]: ");
                                    respostaCadastro = Console.ReadLine().ToUpper();

                                } while (respostaCadastro == "");

                                if (respostaCadastro == "N")
                                {
                                    cadastrado = false;
                                    Console.WriteLine(" *Cadastro cancelado!");
                                }
                                else if (respostaCadastro == "S")
                                {
                                    listaColaboradores.Add(colaborador);

                                    Console.WriteLine("\n *Realizando cadastro, aguarde...");
                                    Console.WriteLine("\n *Cadastro realizado, registro --> {0}", colaborador.Registro);

                                    cadastrado = true;
                                }
                            }

                            break;

                        case "2":   //  ESQUECEU A SENHA
                            RecuperarSenha(infoEmailRecuperacao, colaborador, enviandoCodigoRecuperacaoSenha, codigoRecuperacaoSenhaRecebido, novaSenha, cadastrado);
                            break;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine(" *O campo obrigatoriamente deve conter somente dígitos numéricos!");
                }

            } while (respostaInicial != "3");



        }   //  Fim Main

        static void RecuperarSenha(string? infoEmailRecuperacao, Colaborador colaborador, int enviandoCodigoRecuperacaoSenha, int codigoRecuperacaoSenhaRecebido, string? novaSenha, bool cadastrado)
        {
            Console.WriteLine("\n RECUPERAÇÃO DE SENHA");

            if (cadastrado == true)
            {
                do
                {
                    Console.Write("\n Informe o email: ");
                    infoEmailRecuperacao = Console.ReadLine();

                } while (infoEmailRecuperacao == "");

                if (colaborador.Email == infoEmailRecuperacao)
                {
                    Console.WriteLine("\n *Email válido, código de recuperação enviado para o email '{0}'!", colaborador.Email);

                    Console.WriteLine("\n *Código de recuperação de senha: {0}", codigoRecuperacaoSenhaRecebido);

                    Console.Write("\n Informe o código de recuperação: ");
                    enviandoCodigoRecuperacaoSenha = Convert.ToInt32(Console.ReadLine());

                    if (enviandoCodigoRecuperacaoSenha == codigoRecuperacaoSenhaRecebido)
                    {
                        Console.WriteLine("\n *Código de recuperação válido, recuperação realizada...");

                        Console.Write("\n Insira uma nova senha: ");
                        novaSenha = Console.ReadLine();

                        colaborador.RecuperarSenha(novaSenha);

                        Console.WriteLine("\n Nova senha cadastrada!");
                        Console.WriteLine("\n Direcionando para Login...");
                    }
                    else
                    {
                        Console.WriteLine(" *Código de recuperação inválido, recuperação não realizada!");
                    }
                }
                else { Console.WriteLine(" *Email inválido!"); }
            }
        }

        static void ExibirMenuAreaReservas()
        {
            Console.WriteLine("\nM E N U");
            Console.WriteLine("[1] - FAZER RESERVA");
            Console.WriteLine("[2] - MINHAS RESERVAS");
            Console.WriteLine("[3] - SAIR");
        }

        static void ExibirMenuLogin()
        {
            Console.WriteLine("\nLOGIN");

            Console.WriteLine("\nM E N U");
            Console.WriteLine("[1] - ENTRAR");
            Console.WriteLine("[2] - ESQUECEU A SENHA");
            Console.WriteLine("[3] - SAIR");
        }

        static void ExibirListaEquipamentos(List<Equipamento> listaEquipamentos)
        {
            foreach (var item in listaEquipamentos)
            {
                Console.Write(" | Código:    {0}\t", item.Codigo);
                Console.WriteLine("\t|\t Nome:      {0}", item.Nome);
            }
        }

        static void CriarColaborador(Colaborador colaborador, List<Colaborador> listaColaboradores, bool cadastrado, string? nome, string? senha, string? email)
        {
            do
            {
                Console.Write(" - Nome: ");
                nome = Console.ReadLine();
                colaborador.Nome = nome;

            } while (nome == "");

            do
            {
                Console.Write(" - Senha: ");
                senha = Console.ReadLine();
                colaborador.Senha = senha;

            } while (senha == "");

            do
            {
                Console.Write(" - Email: ");
                email = Console.ReadLine();
                colaborador.Email = email;

            } while (email == "");

            listaColaboradores.Add(colaborador);
            cadastrado = true;
        }

        static void ExibirMenuInicial()
        {
            Console.WriteLine("\nCOLÉGIO VENCER");
            Console.WriteLine("Sistema de Reservas de Equipamentos Audiovisuais");

            Console.WriteLine("\n M E N U");
            Console.WriteLine(" [1] - ENTRAR");
            Console.WriteLine(" [2] - ESQUECEU A SENHA");
            Console.WriteLine(" [3] - SAIR");
        }

    }   //  Fim class Program

}   //  namespace