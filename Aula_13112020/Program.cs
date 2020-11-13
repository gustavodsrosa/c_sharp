using System;

namespace Aula_13112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Qual a sua idade? ");
            int perguntaIdade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Idade em Meses: " + (perguntaIdade * 12));
            Console.WriteLine("Idade em Dias: " + (perguntaIdade * 365));
            Console.WriteLine("Idade em Horas: " + (perguntaIdade * 365 * 24));
            Console.WriteLine("Idade em Minutos: " + (perguntaIdade * 365 * 24 * 60));

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


            // Exercício 2
            Console.WriteLine("Em que ano estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Em que ano você nasceu? ");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Idade atual: " + (anoAtual - anoNasc)); 
            Console.WriteLine("Sua idade em semanas: " + ((anoAtual - anoNasc)*52));

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Exercício 3
            Console.WriteLine("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if(salario < 500){
                Console.WriteLine("Seu salário é de: " + (salario*1.3));
            } else {
                Console.WriteLine("Seu salário é de: " + salario + ". Você não tem direito a aumento");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Desafio

            Console.WriteLine("Qual a idade do nadador?");
            int idadeNadador = int.Parse(Console.ReadLine());

            if(idadeNadador >= 5 && idadeNadador <= 7) {
                Console.WriteLine("Você compete na categoria Infantil A");
            } else if(idadeNadador >= 8 && idadeNadador <= 10) {
                Console.WriteLine("Você compete na categoria Infantil B");
            } else if(idadeNadador >= 11 && idadeNadador <= 13) {
                Console.WriteLine("Você compete na categoria Juvenil A");
            } else if(idadeNadador >= 14 && idadeNadador <= 17) {
                Console.WriteLine("Você compete na categoria Juvenil B");
            } else if(idadeNadador >= 18) {
                Console.WriteLine("Você compete na categoria Sênior");
            } else {
                Console.WriteLine("Você é muito novo para participar da competição");
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
