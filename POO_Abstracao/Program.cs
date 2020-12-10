using System;
using POO_Abstracao.Classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();

            Cartao cartao = new Cartao();

            Credito credito = new Credito();

            Debito debito = new Debito();

            boleto.valores = 2000;

            boleto.parcelas = 3;

            credito.bandeira = "Visa";

            credito.cvv = "12212";

            credito.limite = 2330;

            credito.parcelas = 23;

            credito.valores = 3212;

            boleto.porcentagem = 12/100
        }
    }
}
