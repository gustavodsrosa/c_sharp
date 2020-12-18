using System;
using POO_ObjetoArgumento.Classes;

namespace POO_ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(23, "Mousepad", 29.99f);
            Produto p2 = new Produto(52, "Teclado", 529.99f);
            Produto p3 = new Produto(78, "Headset", 899.99f);
            Produto p4 = new Produto(23, "Mouse", 329.99f);

            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);

            cart.MostrarProduto();
    }
}
