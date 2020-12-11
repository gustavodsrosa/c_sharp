namespace POO_Abstracao.Classes
{
    public class Debito : Cartao
    {
        public float saldo = 600;
        public override void Pagar()
        {
            throw new System.NotImplementedException();
        }
    }
        
}