using System;

namespace Aula_17112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ Código feito em aula ------------

            // While

            Console.WriteLine("Deseja receber um bom dia?");
            string respondendo = Console.ReadLine();

            int numeroDeVezes = 0;

            while(respondendo == "Sim") {
                Console.WriteLine("Tenha um bom dia!");

                numeroDeVezes++;

                Console.WriteLine("Ainda deseja receber um bom dia?");
                respondendo = Console.ReadLine();
            }

            Console.WriteLine($"Número de vezes que foi processado: {numeroDeVezes}");
            Console.WriteLine("Acabou!");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // // Do While

            string resposta = "";

            int numDeVezes = 0;

            do {
                Console.WriteLine("Tenha um bom dia!");
                Console.WriteLine("Ainda deseja receber um bom dia?");

                numDeVezes++;

                resposta = Console.ReadLine();
            } while(resposta == "Sim");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // For

            Console.WriteLine("Qual o número de vezes que você deseja receber um bom dia?");

            for(int resp = 1; resp <= 10; resp++) {
                Console.WriteLine($"{resp} Bom dia!");
            }

            Console.WriteLine();

            for(int resp = 10; resp >= 0; resp--){
                Console.WriteLine($"{resp} segundos para o foguete decolar!");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Decolar!");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // ------------ Exercício proposto em Aula ------------

            int indice1 = 0;
            int indice2 = 0;
            int result;
            

            for(indice1 = 1; indice1 <= 10; indice1++) {
                for(indice2 = 1; indice2 <= 10; indice2++) {
                    result = indice1 * indice2;
                    Console.WriteLine($"{indice1} * {indice2} = {result} ");
                }
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // ------------ Exercícios Material de Aula ------------

            //  For
            //  - Escreva um algoritmo que exiba todos os números inteiros de 0 a 50.

            for(int cont1 = 0; cont1 <= 50; cont1++) {
                Console.WriteLine(cont1);
            }

            Console.WriteLine();

            //  - Escreva um algoritmo que exiba números de 200 à 100 em ordem decrescente

            for(int cont2 = 200; cont2 >= 100; cont2--) {
                Console.WriteLine(cont2);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // While

            //  - Escreva um algoritmo que pergunte a idade de um artista 
            //  famoso e continue perguntando até ela acertar a idade correta, ex: 47

            int contador_while = 0;

            Console.WriteLine("Qual a sua idade, Sr. ?");
            int idade_while = int.Parse(Console.ReadLine());
            while(idade_while != 47) {
                contador_while++;

                Console.WriteLine("Você não lembra sua idade?");
                Console.WriteLine("Qual a sua idade, Sr. ?");
                idade_while = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine($"Você demorou {contador_while} vezes para acertar sua idade...");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Do While

            //  - Escreva um algoritmo que pergunte a idade de um artista 
            //  famoso e continue perguntando até ela acertar a idade correta, ex: 47

            Console.WriteLine("Qual a sua idade, Sr. ?");
            int idade_dowhile = int.Parse(Console.ReadLine());
            int contador_dowhile = 0;

            do {
                contador_dowhile++;
                Console.WriteLine("Você não lembra sua idade?");
                Console.WriteLine("Qual a sua idade, Sr. ?");
                idade_dowhile = int.Parse(Console.ReadLine());
                Console.WriteLine();
            } while(idade_dowhile != 47);

            Console.WriteLine($"Você demorou {contador_dowhile} vezes para acertar sua idade...");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // ------------ Exercícios Material de Aula ------------

            // Escreva um algoritmo que receba o número inteiro e exiba sua tabuada até 10

            Console.WriteLine("Escolha um número para multiplicar");
            int contador_multiplicativo = 0;
            int prod1 = int.Parse(Console.ReadLine());
            int multiplicacao;

            for(contador_multiplicativo = 1; contador_multiplicativo <= 10; contador_multiplicativo++) {
                    multiplicacao = prod1 * contador_multiplicativo;
                    Console.WriteLine($"{prod1} * {contador_multiplicativo} = {multiplicacao}");
                }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
