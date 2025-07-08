using System ;
using BibliotecaDoGera.Model;

bool executar = true;

while (executar)
{

    Console.Clear();
    Console.WriteLine("===== Bem-vindo à Biblioteca do Gera =====");
    Console.WriteLine("1. Cadastrar Usuário");  
    Console.WriteLine("2. Cadastrar Livro");
    Console.WriteLine("3. Listar livros disponíveis");
    Console.WriteLine("4. Emprestar Livro");
    Console.WriteLine("5. Devolver Livro");
    Console.WriteLine("6. Listar Empréstimos ativos");
    Console.WriteLine("7. Histórico de Empréstimos por Usuário");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção:");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome do usuário: ");
            string nome = Console.ReadLine();
            break;
        case "2":
            Console.Write("Título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor do livro: ");
            string autor = Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("Livros disponíveis:");
            break;
        case "4":
            Console.Write("ID do usuário: ");
            int idUsuario = int.Parse(Console.ReadLine());
            Console.Write("ID do livro: ");
            int idLivro = int.Parse(Console.ReadLine());
            break;
        case "5":
           Console.Write("ID do empréstimo: ");
            int idEmprestimo = int.Parse(Console.ReadLine());
            break;
        case "6":
            Console.WriteLine("Empréstimos ativos:");
            break;
        case "7":
            Console.Write("ID do usuário: ");
            int idUsuarioHistorico = int.Parse(Console.ReadLine());
            break;
        case "0":
           executar = false;
            Console.WriteLine("Saindo do sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;

    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}
