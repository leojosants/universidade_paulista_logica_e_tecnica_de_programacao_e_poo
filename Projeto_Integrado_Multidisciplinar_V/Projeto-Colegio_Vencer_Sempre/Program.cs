namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delação de variáveis
            bool cadastrado = false;
            bool logado = false;

            string opcaoInicial;
            string usuario = "";
            string email = "";
            string senha = "";
            string aceiteTermos;
            string validandoUsuarioEmail;
            string validandoUsuarioSenha;
            string escolhaMenu;


            // TELA INICIAL
            Console.WriteLine("\nSeja bem vindo(a)");
            Console.WriteLine("Colégio VENCER SEMPRE");
            Console.WriteLine("Sistema de reserva de equipamentos audiovisuais\n");


            // CADASTRANDO
            Console.WriteLine("-<- CADASTRO ->-");

            Console.Write("Informe seu usuário(*): ");
            do
            {
                usuario = Console.ReadLine();

                if (usuario == "")
                {
                    Console.WriteLine("--> Campo obrigatório!");
                    Console.Write("Informe seu usuário(*): ");
                }

            } while (usuario == "");

            Console.Write("Informe seu email(*): ");
            do
            {
                email = Console.ReadLine();

                if (email == "")
                {
                    Console.WriteLine("--> Campo obrigatório!");
                    Console.Write("Informe seu email(*): ");
                }

            } while (email == "");

            Console.Write("Informe sua senha(*): ");
            do
            {
                senha = Console.ReadLine();

                if (senha == "")
                {
                    Console.WriteLine("--> Campo obrigatório!");
                    Console.Write("Informe sua senha(*): ");
                }

            } while (senha == "");

            Console.Write("Digite 'S' para aceitar os termos e políticas de privacidade(*): ");
            do
            {
                aceiteTermos = Console.ReadLine().ToUpper();

                if (aceiteTermos == "" || aceiteTermos != "S")
                {
                    Console.WriteLine("--> Campo obrigatório, informe somente 'S'");
                    Console.Write("Digite 'S' para aceitar os termos e políticas de privacidade(*): ");
                }

            } while (aceiteTermos == "" || aceiteTermos != "S");

            Console.WriteLine("Usuário '{0}' cadastrado com sucesso, redirecionando para validação de login", usuario);
            cadastrado = true;


            // ENTRAR NO APP
            if (cadastrado == true)
            {
                Console.WriteLine("\n-<- ENTRAR ->-");

                // Validando se usuário já possui cadastro
                do
                {
                    Console.Write("Informe seu usuário ou email: ");
                    validandoUsuarioEmail = Console.ReadLine();

                    Console.Write("Informe sua senha: ");
                    validandoUsuarioSenha = Console.ReadLine();

                } while ((validandoUsuarioEmail != usuario || validandoUsuarioEmail != email) && validandoUsuarioSenha == senha);

                Console.WriteLine("Usuário logado, redirecionando para perfil do usuário!");
                logado = true;


            }









            while (logado)
            {
                Console.WriteLine("Logado");

                // PERFIL
                Console.WriteLine("\n-<- PERFIL ->-");
                Console.WriteLine("[1] - Foto de perfil");
                Console.WriteLine("[5] - Sair");
                Console.Write("Escolha uma opção: ");
                escolhaMenu = Console.ReadLine();

                switch (escolhaMenu)
                {
                    case "1":
                        Console.WriteLine("1");
                        // logado = false;
                        break;

                    case "5":
                        Console.WriteLine("Não logado");
                        logado = false;
                        break;
                }

            }



            // Console.WriteLine("\n-- Pressione QUALQUER TECLA para finalizar programa.");
            // Console.ReadKey();
            Console.WriteLine("\n -- PROGRAMA FINALIZADO! -- \n");

        }
    }

}