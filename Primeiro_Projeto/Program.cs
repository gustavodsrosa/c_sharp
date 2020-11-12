using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Função inicial - Recebendo Usuário
            Console.WriteLine("Qual o seu nome?");
            string perguntaNome = Console.ReadLine();
            Console.WriteLine("Seja muito bem-vindo(a): " + perguntaNome);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Função posterior - Realizando operações matemáticas
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int soma = (numero1 + numero2);
            Console.WriteLine();
            Console.WriteLine("A soma é de: " + soma);
        }
    }
}
