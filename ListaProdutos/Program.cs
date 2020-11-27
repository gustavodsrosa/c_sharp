using System;

namespace ListaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

            Os produtos terão os seguintes atributos:

            - string Nome
            - float Preco
            - bool Promocao (se está em promoção ou não)

            O sistema deverá ter as seguintes funçoes:

            - CadastrarProduto
            - ListarProdutos
            - MostrarMenu
            */

            bool promocao;
            int escolha;
            float preco;
            int contador = 0;

            // Dados

            string[] nomes = new string[10];
            float[] precos = new float[10];


            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("---- Sistema de Produtos ----");
            Console.WriteLine("------------------------------");

            // Menu

            
                Console.WriteLine("Menu principal");
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção para continuar");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Mostrar Produto");
                Console.WriteLine("[0] - Mostrar Menu");
                Console.WriteLine();
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                     void CadastrarProduto() {
                        Console.WriteLine("Cadastrar Produto");
                        
                            if(contador < 10) {
                                for (var i = 0; i < 10; i++)
                                    {
                                        Console.WriteLine($"Digite o nome do {i+1}° produto: ");
                                        nomes[i] = Console.ReadLine();
                                        Console.WriteLine("Digite o preço: ");
                                        precos[i] = float.Parse(Console.ReadLine());
                                    }
                                contador++;
                            } else {
                                Console.WriteLine("Limite excedido! Tente novamente!");
                                break;
                            }
                        Console.Clear();
                        break;
                    }
                        
                    case 2:
                        Console.WriteLine("Listar Passagem");
                        for (var i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Produto {nomes[i]}, Preço {precos[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Muito obrigado pela confiança!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
        } 
    }
}
}

