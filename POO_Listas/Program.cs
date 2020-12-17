using System;
using System.Collections.Generic;
using POO_Listas.Classes;

namespace POO_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto[] arrayProdutos = {};

            produtos.Add(new Produto(5, "Apple", 2121.21f));
            produtos.Add(new Produto(8, "Xiaomi", 3211.21f));
            produtos.Add(new Produto(5, "Motorola", 3124.21f));
            produtos.Add(new Produto(5, "iPhone", 2761.21f));
            produtos.Add(new Produto(5, "Samsung", 1452.27f));

            Produto p = new Produto();
            p.Codigo = 12;
            p.Nome = "Nokia";
            p.Preco = 1234.43f;

            produtos.Add(p);

            foreach(Produto item in produtos) {
                Console.WriteLine(item.Nome);
            }

            Console.Clear();
            Console.WriteLine("Lista de Cartão");

            List<Cartao> cartao= new List<Cartao>();

            Cartao[] arrayCartao = {};

            cartao.Add(new Cartao("Marcos", 98989, "MasterCard", "21/12/2009", 9878));
            cartao.Add(new Cartao("Luiz", 65589, "Visa", "21/01/2019", 9827));
            cartao.Add(new Cartao("Francisco", 14587, "Sodexo", "13/08/2020", 4077));
            cartao.Add(new Cartao("Fernanda", 87577, "HiperCard", "07/02/2020", 2000));
            cartao.Add(new Cartao("César", 7845, "elo", "18/02/2030", 52788));

            Cartao c = new Cartao();
            c.Titular = "Jeremias";
            c.Numero = 12345;
            c.Bandeira = "Diners Club";
            c.Vencimento = "12/12/2012";
            c.Cvv = 9876;

            cartao.Add(c);

            foreach(Cartao item in cartao) {
                Console.WriteLine("Titular: " + item.Titular);
                Console.WriteLine("Número: " + item.Numero);
                Console.WriteLine("Bandeira: " + item.Bandeira);
                Console.WriteLine("Data de vencimento: " + item.Vencimento);
                Console.WriteLine("CVV: " + item.Cvv);
            }





        }
    }
}
