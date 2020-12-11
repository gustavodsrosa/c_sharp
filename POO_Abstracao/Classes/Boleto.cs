using System;
namespace POO_Abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private float codigoDeBarras;
        public float CodigoDeBarras{
            get{return codigoDeBarras;}
        }
        public void Registrar(){
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public void GerarBoleto(){
            float total = this.Valor - (this.Valor * 0.88f);
            Console.WriteLine($"Valor - R$ {total}");
            Console.WriteLine($"Data - {this.Data}");
            Console.WriteLine($"Data de Vencimento - {this.Data.AddDays(10)}");
            Console.WriteLine($"Código de barras - {this.CodigoDeBarras}");
        }
        
        public override double Desconto(double valor)
        {
            return 0;
        }
        
        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}