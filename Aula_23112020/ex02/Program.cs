using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
                Álcool:
                . até 20 litros, desconto de 3% por litro Álcool
                . acima de 20 litros, desconto de 5% por litro
                Gasolina:
                . até 20 litros, desconto de 4% por litro Gasolina
                . acima de 20 litros, desconto de 6% por litro

            Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
            da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
            sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
            Dica: utilize switch case e funções/métodos para otimizar o algorítimo.
            */

            var preco_alcool = 4.90;
            var preco_gasolina = 5.30;
            float desconto_alc;
            float desconto_gas;

            Console.WriteLine("Qtd litros: ");
            float qtd_litros = float.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de Combustivel (A ou G): ");
            string tipo = Console.ReadLine();

            switch (tipo) {
                case "A":
                    if(qtd_litros <= 20) {
                        desconto_alc = 0.03f;
                    } else {
                        desconto_alc = 0.05f;
                    }
                    var total_alcool = preco_gasolina * (qtd_litros - desconto_alc);
                    Console.WriteLine("Valor a pagar: " + total_alcool);
                    break;
                case "G":
                     if(qtd_litros <= 20) {
                        desconto_gas = 0.04f;
                    } else {
                        desconto_gas = 0.06f;
                    }
                    var total_gas = preco_gasolina * (qtd_litros - desconto_gas);
                    Console.WriteLine("Valor a pagar: " + total_gas);
                    break;
                default:
                    Console.WriteLine("Combustível inválido!!");
                    break;
            }

        }
    }
}
