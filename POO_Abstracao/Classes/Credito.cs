namespace POO_Abstracao.Classes
{
    public class Credito : Cartao
    {
        public float limite = 3000;

        public double valores;
        public int parcelas;
        public double porcentagem;

        public override double Desconto(double valor)
        {
            if(parcelas <= 6) {
                porcentagem = 0.05;
            } else if(parcelas >= 7 && parcelas <= 12) {
                porcentagem = 0.08;
            } else {
                
            }
            return valores * porcentagem;
        }

        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}