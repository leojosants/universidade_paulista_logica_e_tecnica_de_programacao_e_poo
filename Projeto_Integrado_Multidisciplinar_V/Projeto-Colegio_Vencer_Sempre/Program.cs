namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n == COLÉGIO VENCER SEMPRE ==");
            Console.WriteLine("-- Sistema de controle de equipamentos audiovisuais -- \n");

            // Delação de variáveis
            string usuario;
            string email;
            string senha;
            bool cadastroRealizado = false;


            // TELA INICIAL
            // Console.Write("Digite [1] para CADASTRAR OU [2] para ENTRAR:");
            // string respostaInicial = Console.ReadLine();


            // CADASTRO DE COLABORADORES
            Console.WriteLine("SEÇÃO DE CADASTRO DE COLABORADORES");

            Console.Write("Informe um USUÁRIO: ");
            usuario = Console.ReadLine();

            if (usuario == "")
            {
                while (usuario == "")
                {
                    Console.Write("--> O campo obrigatório! \n");
                    Console.Write("Informe um USUÁRIO: ");
                    usuario = Console.ReadLine();
                }
            }

            Console.Write("Informe um EMAIL: ");
            email = Console.ReadLine();

            if (email == "")
            {
                while (email == "")
                {
                    Console.Write("--> O campo obrigatório! \n");
                    Console.Write("Informe um EMAIL: ");
                    email = Console.ReadLine();
                }
            }

            Console.Write("Informe uma SENHA: ");
            senha = Console.ReadLine();

            if (senha == "")
            {
                while (senha == "")
                {
                    Console.Write("--> O campo obrigatório! \n");
                    Console.Write("Informe uma SENHA: ");
                    senha = Console.ReadLine();
                }
            }

            Console.Write("Aceita os termos e políticas de privacidade? [S/N] ");
            string resposta = Console.ReadLine();

            if (resposta != "N" || resposta != "n")
            {
                while (resposta == "N" || resposta == "n")
                {
                    Console.Write("--> O campo obrigatório! \n");
                    Console.Write("Aceita os termos e políticas de privacidade [S/N]? ");
                    resposta = Console.ReadLine();
                }
            }

            Console.WriteLine("CADASTRO REALIZADO COM SUCESSO! \n");


            // SEÇÃO DE LOGIN / AUTENTICAÇÃO
            Console.WriteLine("SEÇÃO DE LOGIN / AUTENTICAÇÃO");

            Console.Write("Escolha [1] para ENTRAR ou [2] para ESQUECI MINHA SENHA: ");
            string respostaEsqueceuSenha = Console.ReadLine();

            if (respostaEsqueceuSenha != "1" && respostaEsqueceuSenha != "2")
            {
                while (respostaEsqueceuSenha != "1" && respostaEsqueceuSenha != "2")
                {
                    Console.Write("--> Opção inválida! \n");
                    Console.Write("Escolha [1] para ENTRAR ou [2] para ESQUECI MINHA SENHA: ");
                    respostaEsqueceuSenha = Console.ReadLine();
                }
            }

            if (respostaEsqueceuSenha == "1")
            {
                Console.WriteLine("--> Login");

                Console.Write("Informe USUÁRIO ou EMAIL: ");
                string usuarioAutenticacao = Console.ReadLine();

                if (usuarioAutenticacao != usuario && usuarioAutenticacao != email)
                {
                    while (usuarioAutenticacao != usuario && usuarioAutenticacao != email)
                    {
                        Console.Write("--> Dado incorreto! \n");
                        Console.Write("Informe USUÁRIO ou EMAIL: ");
                        usuarioAutenticacao = Console.ReadLine();
                    }
                }

                Console.Write("Informe sua SENHA: ");
                string senhaAutenticacao = Console.ReadLine();

                if (senhaAutenticacao != senha)
                {
                    while (senhaAutenticacao != senha)
                    {
                        Console.Write("--> Dado incorreto! \n");
                        Console.Write("Informe sua SENHA: ");
                        senhaAutenticacao = Console.ReadLine();
                    }
                }

                Console.WriteLine("--> Acessando perfil do usuário");

            }
            else if (respostaEsqueceuSenha == "2")
            {
                Console.WriteLine("--> Recuperação de senha");

                Console.Write("Informe seu email: ");
                string emailRecuperacao = Console.ReadLine();

                string codigoEnviadoPeloSistema = "1111";

                Console.WriteLine("Enviado código de recuperação para o email {0}", email);

                Console.Write("Insira o código de verificação: ");
                string usuarioEnviandoCodigo = Console.ReadLine();

                if (usuarioEnviandoCodigo != codigoEnviadoPeloSistema)
                {
                    while (usuarioEnviandoCodigo != codigoEnviadoPeloSistema)
                    {
                        Console.Write("--> Código incorreto! \n");
                        Console.Write("Insira o código de verificação corretamente! ");
                        usuarioEnviandoCodigo = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("CÓDIGO VÁLIDO, REDIRECIONANDO PARA LOGIN!");
                }


            }

            Console.WriteLine("\n-- Pressione QUALQUER TECLA para finalizar programa.");
            Console.ReadKey();
            Console.WriteLine("-- PROGRAMA FINALIZADO! \n");

        }
    }
}