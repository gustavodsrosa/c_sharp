using System;
using ex01.Classes;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Digite o número do andar atual: ");
            elevador.andarAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de andares: ");
            elevador.totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a capacidade do elevador: ");
            elevador.capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de passageiros: ");
            elevador.NumPassageiros = int.Parse(Console.ReadLine());

            Console.WriteLine("Você deseja: ");
            Console.WriteLine("[1] - Inicializar elevador");
            Console.WriteLine("[2] - Adicionar passageiro");
            Console.WriteLine("[3] - Remover passageiro");
            Console.WriteLine("[4] - Subir um andar");
            Console.WriteLine("[5] - Descer um andar");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha){
                case 1:
                    Console.WriteLine($"Inicializando elevador: {elevador.Inicializa()}");
                    break;
                case 2:
                    Console.WriteLine($"Número atual de passageiros: {elevador.capacidade}");
                    Console.WriteLine($"Passageiro adicionado. Agora temos {elevador.Entrar()} passageiros");
                    break;
                case 3:
                    Console.WriteLine($"Número atual de passageiros: {elevador.capacidade}");
                    Console.WriteLine($"Passageiro removido. Agora temos {elevador.Sair()} passageiros");
                    break;
                case 4: 
                    Console.WriteLine($"Andar atual: {elevador.andarAtual}");
                    Console.WriteLine($"Subindo um andar: {elevador.Subir()}");
                    break;
                case 5:
                    Console.WriteLine($"Andar atual: {elevador.andarAtual}");
                    Console.WriteLine($"Descendo um andar: {elevador.Descer()}");
                    break;
            }
        }
    }
}
