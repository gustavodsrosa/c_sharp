using System;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Stanley Ipkiss";
            jogador1.idade = 30;
            jogador1.armadura = "Máscara do Loki";
            jogador1.iA = "";

            // Console.WriteLine(jogador1.nome);

            Personagem jogador2 = new Personagem();
            jogador2.nome = "¨Tony Stark";
            jogador2.idade = 30;
            jogador2.armadura = "Mark1";
            jogador2.iA = "";

            if (jogador1.iA == "" || jogador2.iA == "") {
                jogador1.iA = "Não possui iA";
                jogador2.iA = "Não possui iA";
            }

            Console.WriteLine();
            Console.WriteLine("Primeiro Jogador");
            Console.WriteLine("Nome: " + jogador1.nome);
            Console.WriteLine("Idade: " + jogador1.idade);
            Console.WriteLine("Armadura: " + jogador1.armadura);
            Console.WriteLine("IA: " + jogador1.iA);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Segundo Jogador");
            Console.WriteLine("Nome: " + jogador2.nome);
            Console.WriteLine("Idade: " + jogador2.idade);
            Console.WriteLine("Armadura: " + jogador2.armadura);
            Console.WriteLine("IA: " + jogador2.iA);

            Console.WriteLine($"{jogador1.nome} -> " + jogador1.Ataque1());
            Console.WriteLine($"{jogador2.nome} -> " + jogador1.Ataque1());

            int vidaJogador2 = jogador2.Defesa(jogador1.Ataque2());

            if(vidaJogador2 <= 0) {
                Console.WriteLine("K.O.");
            } else {
                Console.WriteLine($"Vida restante: {jogador2.vida}");
            }

        }
    }
}
