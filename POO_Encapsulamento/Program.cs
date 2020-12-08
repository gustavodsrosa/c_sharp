using System;
using POO_Encapsulamento.Classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard master = new MasterCard();

            master.NomeTitular = "Gustavo";

            Console.WriteLine(master.NomeTitular);

            master.Numero = "123456789987";

            Console.WriteLine(master.Numero);
            
            master.Bandeira = "Mastercard";

            Console.WriteLine(master.Bandeira);

            Console.WriteLine(master.Token);

            master.Cvv = "123323213";

            Console.WriteLine(master.Cvv);

            
        }
    }
}
