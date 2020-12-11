using System;
namespace POO_Polimorfismo_Sobrecarga
{
    public class Funcionario
    {
        public string Name {get;set;}

        public string[] lista = {"Gustavo", "Fabio", "Maicon", "Antonio"};

        public void Mostrar(){
            foreach(var item in lista) {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int indice) {
            Console.WriteLine($"Busca por índice: {lista[indice]}");
        }
        public void Mostrar(string busca) {
            foreach(var item in lista) {
                if(item == busca) {
                    Console.WriteLine($"Resultado: {item}");
                }

            }
        }
    }
}