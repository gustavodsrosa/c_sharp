using System;
namespace ex01.Classes
{
    public class Elevador
    {
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        private int numPassageiros;
        public int NumPassageiros{
            get;set;
        }
        public int Inicializa(){
            return capacidade;
            return totalAndares;
        }
        public int Entrar(){
            return capacidade += 1;
        }
        public int Sair(){
            return capacidade -= 1;
        }
        public int Subir(){
            if(andarAtual > totalAndares) {
                Console.WriteLine("Não é possível subir mais um andar");
            } 
            return andarAtual += 1;
            
        }
        public int Descer(){
            if(andarAtual <= 0) {
                Console.WriteLine("Não é possível descer mais um andar");
            }
            return andarAtual -= 1;
            
        }
    }
}