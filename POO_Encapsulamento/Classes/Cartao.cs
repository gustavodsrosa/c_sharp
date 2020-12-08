using System;

namespace POO_Encapsulamento.Classes {

    public class Cartao {

        private string numero;

        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        private string nomeTitular;
        public string NomeTitular {
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }
        private string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string Cvv{ 
            get{return cvv;}
            set{cvv = value;}
        }
        protected float limite = 5000;
        public float Limite{get{return limite;}set{limite = value;}}

        public string RegistrarCompra(bool validado) {
            return "";
        }


    }
}