using System;
using POO_Interface.Classes;

namespace POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carrinho cart = new Carrinho();
            
            Produto p1 = new Produto();
            p1.Codigo = 123456;
            p1.Nome = "Jogo";
            p1.Preco = "999";

            Produto p2 = new Produto();
            p2.Codigo = 17896;
            p2.Nome = "Mobilete";
            p2.Preco = "1999";

            cart.Cadastrar(p1);
            cart.Listar();
            cart.Cadastrar(p2);
            cart.Alterar(p1.Codigo, p2);
            cart.Listar();
            
        }
    }
}
