namespace POO_Abstracao.Classes
{
    public class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        public string SalvarCartao(){
            return "";
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