using System;
namespace POO_Construtor.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public Produto(int codigo, string nome, string descricao, int estoque) {
            if(codigo < 0) {
                Console.WriteLine("Valor inválido!");
            } else {
                Codigo = codigo;
                Nome = nome;
                Descricao = descricao;
                Estoque = estoque;

                Console.WriteLine($"Código -> {Codigo}, Nome -> {Nome}, Descrição -> {Descricao}, Estoque -> {Estoque}");
            }
        }
        public Produto(int codigo) {
            if(codigo >= 0) {
                Codigo = codigo;
                Nome = "Pepsi";
                Console.WriteLine($"Produto cadastrado: {Codigo}, {Nome ?? "Sem nome"}");
            } else {
                Console.WriteLine("Inválido");
            }
        }
        
        
        
        
        
        
    }
}