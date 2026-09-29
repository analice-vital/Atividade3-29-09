using System;
using FitManager.Classes;
using FitManager.Services;

namespace FitManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = "dados_academia.json";

            Academia academia;

            try
            {
                academia = JsonService.Carregar(caminho);
            }
            catch (Exception)
            {
                academia = new Academia("Power Fit Academia");
            }

            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("       POWER FIT ACADEMIA");
                Console.WriteLine("          FITMANAGER");
                Console.WriteLine("======================================");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Cadastrar funcionário");
                Console.WriteLine("4 - Listar funcionários");
                Console.WriteLine("5 - Cadastrar plano");
                Console.WriteLine("6 - Listar planos");
                Console.WriteLine("7 - Criar matrícula");
                Console.WriteLine("8 - Cadastrar mensalidade");
                Console.WriteLine("9 - Registrar pagamento");
                Console.WriteLine("10 - Consultar valor em aberto");
                Console.WriteLine("11 - Consultar mensalidades atrasadas");
                Console.WriteLine("12 - Gerar código de atendimento");
                Console.WriteLine("13 - Salvar dados");
                Console.WriteLine("14 - Carregar dados");
                Console.WriteLine("15 - Testar polimorfismo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("======================================");

                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    switch (opcao)
                    {
                        case 1:
                            CadastrarAluno(academia);
                            break;

                        case 2:
                            ListarAlunos(academia);
                            break;

                        case 3:
                            CadastrarFuncionario(academia);
                            break;

                        case 4:
                            ListarFuncionarios(academia);
                            break;

                        case 5:
                            CadastrarPlano(academia);
                            break;

                        case 6:
                            ListarPlanos(academia);
                            break;

                        case 7:
                            CriarMatricula(academia);
                            break;

                        case 8:
                            CadastrarMensalidade(academia);
                            break;

                        case 9:
                            RegistrarPagamento(academia);
                            break;

                        case 10:
                            ConsultarValorEmAberto(academia);
                            break;

                        case 11:
                            ConsultarAtrasadas(academia);
                            break;

                        case 12:
                            Console.WriteLine(
                                $"Código de atendimento: {Academia.GerarCodigoAtendimento()}");
                            break;

                        case 13:
                            JsonService.Salvar(academia, caminho);
                            Console.WriteLine("Dados salvos com sucesso!");
                            break;

                        case 14:
                            academia = JsonService.Carregar(caminho);
                            Console.WriteLine("Dados carregados com sucesso!");
                            break;

                        case 15:
                            TestarPolimorfismo();
                            break;

                        case 0:
                            JsonService.Salvar(academia, caminho);
                            Console.WriteLine("Sistema encerrado.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }

        static void CadastrarAluno(Academia academia)
        {
            Console.WriteLine("\n--- CADASTRO DE ALUNO ---");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Objetivo: ");
            string objetivo = Console.ReadLine();

            Console.Write("Plano atual: ");
            string plano = Console.ReadLine();

            Aluno aluno = new Aluno(
                id,
                nome,
                cpf,
                telefone,
                email,
                objetivo,
                plano
            );

            academia.AdicionarAluno(aluno);

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static void ListarAlunos(Academia academia)
        {
            Console.WriteLine("\n--- ALUNOS CADASTRADOS ---");

            if (academia.Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            foreach (Aluno aluno in academia.Alunos)
            {
                Console.WriteLine(aluno.ExibirResumo());
            }
        }

        static void CadastrarFuncionario(Academia academia)
        {
            Console.WriteLine("\n--- CADASTRO DE FUNCIONÁRIO ---");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(
                id,
                nome,
                cpf,
                telefone,
                email,
                cargo
            );

            academia.AdicionarFuncionario(funcionario);

            Console.WriteLine("Funcionário cadastrado!");
        }

        static void ListarFuncionarios(Academia academia)
        {
            Console.WriteLine("\n--- FUNCIONÁRIOS ---");

            foreach (Funcionario funcionario in academia.Funcionarios)
            {
                Console.WriteLine(funcionario.ExibirResumo());
            }
        }

        static void CadastrarPlano(Academia academia)
        {
            Console.WriteLine("\n--- CADASTRO DE PLANO ---");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome do plano: ");
            string nome = Console.ReadLine();

            Console.Write("Valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Duração em meses: ");
            int duracao = int.Parse(Console.ReadLine());

            Plano plano = new Plano(
                id,
                nome,
                valor,
                duracao
            );

            academia.AdicionarPlano(plano);

            Console.WriteLine("Plano cadastrado!");
        }

        static void ListarPlanos(Academia academia)
        {
            Console.WriteLine("\n--- PLANOS ---");

            foreach (Plano plano in academia.Planos)
            {
                Console.WriteLine(plano.ExibirPlano());
            }
        }

        static void CriarMatricula(Academia academia)
        {
            Console.WriteLine("\n--- NOVA MATRÍCULA ---");

            Console.Write("ID da matrícula: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("ID do aluno: ");
            int alunoId = int.Parse(Console.ReadLine());

            Console.Write("ID do plano: ");
            int planoId = int.Parse(Console.ReadLine());

            Matricula matricula = new Matricula(
                id,
                alunoId,
                planoId,
                DateTime.Now
            );

            academia.AdicionarMatricula(matricula);

            Console.WriteLine("Matrícula criada com sucesso!");
        }

        static void CadastrarMensalidade(Academia academia)
        {
            Console.WriteLine("\n--- NOVA MENSALIDADE ---");

            Console.Write("ID da mensalidade: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("ID do aluno: ");
            int alunoId = int.Parse(Console.ReadLine());

            Console.Write("Valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Dias até o vencimento: ");
            int dias = int.Parse(Console.ReadLine());

            DateTime vencimento = DateTime.Now.AddDays(dias);

            Mensalidade mensalidade =
                new Mensalidade(
                    id,
                    alunoId,
                    valor,
                    vencimento
                );

            academia.AdicionarMensalidade(mensalidade);

            Console.WriteLine("Mensalidade cadastrada!");
        }

        static void RegistrarPagamento(Academia academia)
        {
            Console.WriteLine("\n--- REGISTRAR PAGAMENTO ---");

            Console.Write("ID da mensalidade: ");
            int id = int.Parse(Console.ReadLine());

            Mensalidade mensalidade =
                academia.Mensalidades.Find(m => m.Id == id);

            if (mensalidade == null)
            {
                Console.WriteLine("Mensalidade não encontrada.");
                return;
            }

            mensalidade.RegistrarPagamento();

            Console.WriteLine("Pagamento registrado com sucesso!");
        }

        static void ConsultarValorEmAberto(Academia academia)
        {
            Console.WriteLine("\n--- VALOR EM ABERTO ---");

            Console.Write("ID do aluno: ");
            int alunoId = int.Parse(Console.ReadLine());

            decimal total =
                academia.CalcularValorEmAberto(alunoId);

            Console.WriteLine(
                $"Valor total em aberto: R$ {total:F2}");
        }

        static void ConsultarAtrasadas(Academia academia)
        {
            Console.WriteLine("\n--- MENSALIDADES ATRASADAS ---");

            bool encontrou = false;

            foreach (Mensalidade mensalidade in academia.Mensalidades)
            {
                if (mensalidade.EstaAtrasada())
                {
                    Console.WriteLine(
                        $"ID: {mensalidade.Id} | " +
                        $"Aluno: {mensalidade.AlunoId} | " +
                        $"Valor: R$ {mensalidade.Valor:F2} | " +
                        $"Vencimento: {mensalidade.Vencimento:dd/MM/yyyy}"
                    );

                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("Nenhuma mensalidade atrasada.");
            }
        }

        static void TestarPolimorfismo()
        {
            Console.WriteLine("\n--- TESTE DE POLIMORFISMO ---");

            Pessoa aluno = new Aluno(
                1,
                "Ana",
                "000.000.000-00",
                "(00) 00000-0000",
                "ana@email.com",
                "Hipertrofia",
                "Premium"
            );

            Pessoa funcionario = new Funcionario(
                2,
                "Carlos",
                "111.111.111-11",
                "(00) 11111-1111",
                "carlos@email.com",
                "Recepcionista"
            );

            Console.WriteLine(aluno.ExibirResumo());
            Console.WriteLine(funcionario.ExibirResumo());
        }
    }
}
