using System;
using POO_Abstracao.Classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da compra: ");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione um método de pagamento");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Boleto boleto = new Boleto();
                    boleto.Registrar();
                    Console.WriteLine($"Código de Barras - {boleto.CodigoDeBarras}");
                    boleto.Valor = valorDaCompra;
                    boleto.Data = DateTime.Now;

                    boleto.GerarBoleto();
                    break;
                case 2:
                    Console.WriteLine("Selecione um método de pagamento");
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    int tipo = int.Parse(Console.ReadLine());
                    switch(tipo) {
                        case 1:
                            Credito credito = new Credito();
                            credito.valorFinal = 1221;
                            credito.Gerar();
                            break;
                        case 2:
                            Debito debito = new Debito();
                            Console.WriteLine($"Valor Final: {debito.saldo}");
                            break;
                        default:
                            Console.WriteLine("Opção inválida, tente novamente!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente!!");
                    break;
            }
            

        }
    }
}
