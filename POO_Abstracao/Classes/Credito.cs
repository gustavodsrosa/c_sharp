using System;
namespace POO_Abstracao.Classes
{
    public class Credito : Cartao
    {
        public float limite = 3000;
        public int parcelas;
        public float valorFinal = 1221;
        public override void Pagar()
        {
            
            
        }
        public void Gerar(){
            if(parcelas <= 6) {
                float total = valorFinal - (valorFinal * 0.95f);
            } else if(parcelas >= 6 && parcelas <= 12) {
                float total2 = this.Valor - (this.Valor * 0.92f);
            } else {
                Console.WriteLine($"Não existe");
            }
                Console.WriteLine($"Valor - R$ {valorFinal}");
        }
        
        
    }
}