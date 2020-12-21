using System;
namespace POO_Final_Produtos.Classes
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login() {
            Logar();

            if(Logado == true){
                GerarMenu();
            }
        }
        public void GerarMenu() {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "n";
            do{
                Console.WriteLine($"Escolha uma opção:");
                Console.WriteLine($"1 - Cadastrar Marca");
                Console.WriteLine($"2 - Listar Marca");
                Console.WriteLine($"3 - Excluir Marca");
                Console.WriteLine($"4 - Cadastrar Produto");
                Console.WriteLine($"5 - Listar Produto");
                Console.WriteLine($"6 - Excluir Produto");
                Console.WriteLine($"0 - Sair");
                
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar();
                        break;
                    case "2":
                        marca.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Digite um código para excluir: ");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                        break;
                    case "4":
                        produto.Cadastrar();
                        break;
                    case "5":
                        produto.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Digite um código para excluir: ");
                        int codigo2 = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo2);
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }
                
                
            } while(opcao != "0");
        }

        public void Logar() {
            Usuario user = new Usuario();

            Console.WriteLine("Digite seu email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine($"Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == user.Email && senhaLogin == user.Senha) {
                Logado = true;
                Console.WriteLine("Logado com sucesso");
            } else {
                Console.WriteLine($"Falha no login!");
            }

            

        }

        public void Deslogar() {
            Logado = false;
        }
        
        
    }
}