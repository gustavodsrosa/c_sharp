using System;
namespace ex02.Classes
{
    public class Jogador
    {
        public string nome;
        public string posicao;
        public int anoNasc;
        public string nacionalidade;
        public float altura;
        public float peso;
        public int anoAtual;
        public int Idade(){
            return anoAtual - anoNasc;
        }
        public string Aposentar(){
            return "";
        }

    }
}