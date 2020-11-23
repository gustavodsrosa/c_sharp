using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
            ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            */

            int ano_atual = 2020;


            Console.WriteLine("Ano de nascimento: ");
            int ano_nasc = int.Parse(Console.ReadLine());

            int podeVotar = ano_atual - ano_nasc;

            Console.WriteLine("Lembrando: ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Voto facultativo: Jovens de 16 e 17 anos e Idosos com idade acima de 70 anos");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Voto obrigatório: Eleitores adultos entre os 18 e os 69 anos de idade");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Então: ");
            System.Threading.Thread.Sleep(500);

            if(podeVotar >= 18 && podeVotar < 70) {
                Console.WriteLine("Seu voto é obrigatório");
            } else {
                Console.WriteLine("Seu voto é facultativo");
            }




        }
    }
}
