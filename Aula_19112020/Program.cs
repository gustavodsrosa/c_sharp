using System;

namespace Aula_19112020
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = {"abacate", "melancia", "arroz", "abacaxi", "feijão", "carne", "maracuja", "maçã", "pera"};
            double[] lista_precos = {12.10, 13.50, 15.00, 14.90, 15.99, 7.99, 8.99, 7.95, 15.99};
            int[] valores_int = {1,2,3,4,5,6,7};

            Console.WriteLine("Itens do mercado: ");
            for(int i = 0; i < lista.Length; i++) {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Preços: ");
            for(int i = 0; i < lista_precos.Length; i++) {
                Console.WriteLine(lista_precos[i]);
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Valores: ");
            for(int i = 0; i < valores_int.Length; i++) {
                Console.WriteLine(valores_int[i]);
            }


        }
    }
}
