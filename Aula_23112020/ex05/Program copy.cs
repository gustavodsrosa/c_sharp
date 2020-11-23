using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
            Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
            */
            
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
        }
    }
}
