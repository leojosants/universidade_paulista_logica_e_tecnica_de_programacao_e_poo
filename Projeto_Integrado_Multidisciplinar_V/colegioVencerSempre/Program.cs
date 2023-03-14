namespace colegioVencerSempre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            bool logado = false;
            bool cadastrado = false;

            string opcaoInicial;
            string usuario = "";
            string email = "";
            string senha = "";
            string validandoPorUsuarioOuEmail;
            string validandoPorSenha;
            string respostaAceitarTermos;
            string respostaDesejaNovoCadastro;
            string respostaEsqueceuSenha;
            string respostaRecuperSenha;
            string codigoRecuperacaoSenha = "xxxx";
            string respostaCodigoRecuperacaoSenha;

            Console.WriteLine("\nSeja bem vindo(a)");
            Console.WriteLine("Colégio VENCER SEMPRE");
            Console.WriteLine("Sistema de reserva de equipamentos audiovisuais\n");

            // CADASTRO
            do
            {
                Console.WriteLine("[C] - CADASTRAR");
                Console.WriteLine("[E] - ENTRAR");
                Console.WriteLine("[S] - SAIR");

                Console.Write("Escolha uma opção: ");
                opcaoInicial = Console.ReadLine().ToUpper();

                while (opcaoInicial == "")
                {
                    Console.WriteLine("[C] - CADASTRAR");
                    Console.WriteLine("[E] - ENTRAR");
                    Console.WriteLine("[S] - SAIR");
                    Console.Write("Escolha uma opção: ");
                    opcaoInicial = Console.ReadLine().ToUpper();
                }

                // CADASTRO / ENTRAR
                if (opcaoInicial == "C" || opcaoInicial == "E")
                {

                    // CADASTRO
                    if (opcaoInicial == "C")
                    {
                        Console.WriteLine("\n - CADASTRAR - ");
                        do
                        {
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

                            // 
                            Console.Write("Digite 'S' para aceitar os termos e políticas de privacidade(*): ");
                            do
                            {
                                respostaAceitarTermos = Console.ReadLine().ToUpper();
                                Console.WriteLine("--> Campo obrigatório, informe somente 'S'");

                                if (respostaAceitarTermos == "" || respostaAceitarTermos != "S")
                                {
                                    Console.Write("Digite 'S' para aceitar os termos e políticas de privacidade(*): ");
                                }

                                cadastrado = true;

                            } while (respostaAceitarTermos == "" || respostaAceitarTermos != "S");

                            Console.WriteLine("Usuário '{0}'cadastrado com sucesso!\n", usuario);
                            Console.Write("Deseja cadastrar novo usuário [S/N]? ");
                            respostaDesejaNovoCadastro = Console.ReadLine().ToUpper();


                        } while (respostaDesejaNovoCadastro != "N");

                    }


                    // ENTRAR - LOGIN
                    else if (opcaoInicial == "E")
                    {
                        Console.WriteLine("\n - ENTRAR - ");

                        // USUÁRIO AINDA NAO POSSUI CADASTRO
                        if (cadastrado == false)
                        {
                            Console.WriteLine("Para acessar o sistema pela primeira vez, favor realizar cadastro, redirecionando para cadastro...");
                            Console.WriteLine("\n - CADASTRAR - ");

                            do
                            {
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
                                    respostaAceitarTermos = Console.ReadLine().ToUpper();
                                    Console.WriteLine("--> Campo obrigatório, informe somente 'S'");

                                    if (respostaAceitarTermos == "" || respostaAceitarTermos != "S")
                                    {
                                        Console.Write("Digite 'S' para aceitar os termos e políticas de privacidade(*): ");
                                    }

                                    cadastrado = true;

                                } while (respostaAceitarTermos == "" || respostaAceitarTermos != "S");

                                Console.WriteLine("Usuário '{0}'cadastrado com sucesso!\n", usuario);

                                Console.Write("Deseja cadastrar novo usuário [S/N]? ");
                                respostaDesejaNovoCadastro = Console.ReadLine().ToUpper();

                            } while (respostaDesejaNovoCadastro != "N");
                        }

                        // USUÁRIO JÁ POSSUI CADASTRO
                        else if (cadastrado == true)
                        {
                            // RECUPERANDO SENHA
                            Console.Write("Esqueceu a senha [S/N]? ");
                            respostaEsqueceuSenha = Console.ReadLine().ToUpper();

                            if (respostaEsqueceuSenha == "S")
                            {
                                Console.WriteLine(" - RECUPERAR SENHA - ");

                                do
                                {
                                    Console.Write("Informe seu email: ");
                                    respostaRecuperSenha = Console.ReadLine();

                                    if (respostaRecuperSenha != email)
                                    {
                                        Console.WriteLine("--> Campos em branco ou email inválido, tente novamente!");
                                    }

                                } while (respostaRecuperSenha != email);

                                Console.WriteLine("Código de recuperação de senha enviado para o email '{0}' do usuário '{1}'.", email, usuario);

                                do
                                {
                                    Console.Write("Informe o código de recuperação: ");
                                    respostaCodigoRecuperacaoSenha = Console.ReadLine();

                                    // Validando código de recuperação
                                    if (respostaCodigoRecuperacaoSenha == codigoRecuperacaoSenha)
                                    {
                                        Console.WriteLine("Recuperação de senha realizada... direcionando para perfil do usuário...");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Código inválido, tente novamente!");
                                    }

                                } while (respostaCodigoRecuperacaoSenha != codigoRecuperacaoSenha);

                                logado = true;

                                Console.WriteLine("Usuário '{0} logado! \n", usuario);

                            }
                            else if (respostaEsqueceuSenha == "N")
                            {
                                Console.Write("Informe seu usuário ou email: ");
                                do
                                {
                                    validandoPorUsuarioOuEmail = Console.ReadLine();

                                    if (validandoPorUsuarioOuEmail == "" || (validandoPorUsuarioOuEmail != usuario && validandoPorUsuarioOuEmail != email))
                                    {
                                        Console.WriteLine("--> Campo em branco ou dados incorretos, tente novamente!");
                                        Console.Write("Informe seu usuário ou email: ");
                                    }

                                } while (validandoPorUsuarioOuEmail == "" || (validandoPorUsuarioOuEmail != usuario && validandoPorUsuarioOuEmail != email));

                                Console.Write("Informe sua senha: ");
                                do
                                {
                                    validandoPorSenha = Console.ReadLine();

                                    if (validandoPorSenha == "" || (validandoPorSenha != senha))
                                    {
                                        Console.WriteLine("--> Campo em branco ou dados incorretos, tente novamente!");
                                        Console.Write("Informe seu usuário ou email: ");
                                    }

                                } while (validandoPorSenha == "" || (validandoPorSenha != senha));

                                Console.WriteLine("Verificando dados... - Usuário autentivado - Direcionando para perfil do usuário");

                                logado = true;
                                Console.WriteLine("Usuário '{0} logado! \n", usuario);
                            }
                        }

                    }
                }

            } while (opcaoInicial != "S");

            // Console.WriteLine("\n-- Pressione QUALQUER TECLA para finalizar programa.");
            // Console.ReadKey();
            Console.WriteLine("\n -- PROGRAMA FINALIZADO! -- \n");

        }
    }

}
