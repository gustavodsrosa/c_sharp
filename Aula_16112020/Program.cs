using System;

namespace Aula_16112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculadora simples

            Console.WriteLine("Qual a operação que você quer fazer?\nDigite uma das 4 operações básicas\nObs: Tudo maiúsculo");
            string operacao = Console.ReadLine();

            // Pedir os dois números ao usuário

            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());


            // Calculadora com switch/case
            float resultado = 0;

            switch(operacao) {
                case "SOMA":
                    resultado = num1 + num2;
                    break;
                case "SUBTRACAO": 
                    resultado = num1 - num2;
                    break;
                case "MULTIPLICACAO":
                    resultado = num1 * num2;
                    break;
                case "DIVISAO":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Tente novamente");
                    break;
            }

            Console.WriteLine($"{num1} com {num2} = {resultado}");
        }
    }
}
