using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
            menor valor lido.
            */

            Console.WriteLine("Valor: ");
            int valores = int.Parse(Console.ReadLine());
            int maior = valores;
            int menor = valores;

            for(int i = 0; i < 9; i++) {
                Console.WriteLine("Valor: ");
                valores = int.Parse(Console.ReadLine());

                if(valores > maior) {
                    maior = valores;
                } else if(valores < menor) {
                    menor = valores;
                }
            }

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
        }
    }
}

