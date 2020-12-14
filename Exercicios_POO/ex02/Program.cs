using System;
using ex02.Classes;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            Console.WriteLine("Digite o seu nome: ");
            jogador.nome = Console.ReadLine();

            Console.WriteLine("Digite sua posição: ATACANTE/MEIA/DEFESA");
            jogador.posicao = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o ano de nascimento: ");
            jogador.anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nacionalidade:");
            jogador.nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            jogador.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            jogador.peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            jogador.anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine($"Idade do jogador: {jogador.Idade()}");

            if(jogador.posicao == "DEFESA") {
                if(jogador.Idade() > 40) {
                    Console.WriteLine("Você já está aposentado");
                } else{
                    Console.WriteLine(40 - jogador.Idade());
                }
            } else if(jogador.posicao == "MEIO") {
                if(jogador.Idade() > 38) {
                    Console.WriteLine("Você já está aposentado");
                } else{
                    Console.WriteLine(38 - jogador.Idade());
                }
            } else if(jogador.posicao == "MEIA") {
                if(jogador.Idade() > 35) {
                    Console.WriteLine("Você já está aposentado");
                } else {
                    Console.WriteLine(35 - jogador.Idade());
                }
            }
        }
    }
}
