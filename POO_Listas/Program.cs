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

        }
    }
}
