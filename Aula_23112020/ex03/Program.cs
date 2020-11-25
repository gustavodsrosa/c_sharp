using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            - Se quantidade <= 5 o desconto será de 2%
            - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            - Se quantidade > 10 o desconto será de 5%
            Dica: utilize if / else if / else
            */

            Console.WriteLine("Descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Quantidade: ");
            float qtd = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Preço unitário: ");
            float pr_unitario = float.Parse(Console.ReadLine());

            Console.WriteLine();

            if(qtd <= 5) {
                var desconto = 0.02;
                var total = qtd * pr_unitario;
                var total_a_pagar = total - desconto;
                Console.WriteLine("Total a pagar: " + total_a_pagar);
            } else if(qtd > 5 && qtd <= 10) {
                var desconto = 0.03;
                var total = qtd * pr_unitario;
                var total_a_pagar = total - desconto;
                Console.WriteLine("Total a pagar: " + total_a_pagar);
            } else {
                var desconto = 0.05;
                var total = qtd * pr_unitario;
                var total_a_pagar = total - desconto;
                Console.WriteLine("Total a pagar: " + total_a_pagar);
            }








        }
    }
}
