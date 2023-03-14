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
            bool termosEPoliticas;
            bool cadastroRealizado = false;

            // Console.WriteLine("Cadastro realizado: {0}", cadastroRealizado);

            // Cadastrando colaboradores
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



            // // Exibindo dados
            // Console.WriteLine("\nDados informados:");
            // Console.WriteLine("Nome: {0}", nome);
            // Console.WriteLine("Professor? {0}", professor);
            // Console.WriteLine("Coordenador? {0}", coordenador);
            // Console.WriteLine("Disciplina: {0}", disciplina);
            // Console.WriteLine("Email: {0}", email);
            // Console.WriteLine("Telefone: {0}", telefone);
            // Console.WriteLine("Registro: {0}", registro);

            // Login
            // Console.WriteLine("SEÇÃO DE LOGIN");
            // Console.WriteLine("Informe seu USUÁRIO");

            Console.WriteLine("\n-- Pressione QUALQUER TECLA para finalizar programa.");
            Console.ReadKey();
            Console.WriteLine("-- PROGRAMA FINALIZADO! \n");

        }
    }
}