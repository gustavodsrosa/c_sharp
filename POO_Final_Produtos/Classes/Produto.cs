using System;
using System.Collections.Generic;
namespace POO_Final_Produtos.Classes
{
    public class Produto 
    {
        public int Codigo { get; set; }
        
        public string NomeProduto { get; set; }
        
        public float Preco { get; set; }
        
        public DateTime DataCadastro { get; set; }
        public Marca marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();
        public void Cadastrar() {
            Produto novoProduto = new Produto();

            System.Console.WriteLine($"Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.marca = marca.Cadastrar();

            novoProduto.CadastradoPor = new Usuario();
            
            DataCadastro = DateTime.UtcNow;

            ListaDeProdutos.Add(novoProduto);

        }
        public void Listar() {
            foreach(Produto item in ListaDeProdutos) {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                
            }
        }
        public void Deletar(int cod) {
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }

        
        
        
        
        
        
    }
}