using System;
namespace POO_Abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }
        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }
        public double valores;
        public double porcentagem = 0.88;
        public int parcelas;

        public override double Desconto(double valor)
        {
            return valores * porcentagem;
        }
        
        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}