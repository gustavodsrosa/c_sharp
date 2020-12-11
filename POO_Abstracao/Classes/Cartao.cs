namespace POO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        public string SalvarCartao(){
            return "Cartão salvo!";
        }
        public abstract void Pagar();
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