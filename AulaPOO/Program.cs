using System;

namespace AulaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            Console.WriteLine("Está ligado? s/n");
            string escolha = Console.ReadLine();

            if(escolha == "s") {
                celular.ligado = true;
            } else if(escolha == "n") {
                celular.ligado = false;
            }

            
            Console.WriteLine("Digite a cor: ");
            celular.cor = Console.ReadLine();

            Console.WriteLine("Digite o modelo: ");
            celular.modelo = Console.ReadLine();

            Console.WriteLine("Digite o tamanho: ");
            celular.tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o telefone: ");
            celular.telefone = Console.ReadLine();

            Console.WriteLine("[1] Ligar ou Desligar");
            Console.WriteLine("[2] Opções");
            Console.WriteLine("[0] Sair");
            int escolher = int.Parse(Console.ReadLine());

            switch (escolher)
            {
                case 1:
                    Console.WriteLine("Você deseja ligar ou desligar seu celular? LIGAR/DESLIGAR");
                    string ligando = Console.ReadLine().ToUpper();

                    if(ligando == "LIGAR") {
                        Console.WriteLine("Ligando...");
                    } else if(ligando == "DESLIGAR") {
                        Console.WriteLine("Desligando...");
                    }
                    break;
                    case 2: 
                    Console.WriteLine("[1] Fazer ligação");
                    Console.WriteLine("[2] Enviar Mensagem");
                    Console.WriteLine("[3] Sobre o celular");
                    int escolher2 = int.Parse(Console.ReadLine());
                    switch(escolher2) {
                        case 1:
                            celular.FazerLigacao(celular.telefone);
                            break;
                        case 2:
                            celular.EnviarMensagem(celular.telefone);
                            
                            break;
                        case 3:
                            Console.WriteLine("Especificações do celular: ");
                            Console.WriteLine($"Cor: {celular.cor}");
                            Console.WriteLine($"Tamanho: {celular.tamanho}");
                            Console.WriteLine($"Modelo: {celular.modelo}");
                            
                            break;
                    }
                    break;
                case 0:
                    Console.WriteLine("Obrigado!");
                    
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    
                    break;
            }
        }
    }
}
