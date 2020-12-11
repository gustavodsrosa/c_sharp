using System;

namespace POO_Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;
        private bool status;
        public float Valor{
            get;set;
        }
        public DateTime Data{
            get;set;
        }

        public string Cancelar(){
            this.status = false;
            return "";
        }

        public abstract double Desconto(double valor);
        public abstract string Juros(int parcelas);
    }
}