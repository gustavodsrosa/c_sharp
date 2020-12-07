using System;

using POO_Heranca.Classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa Física
            PessoaFisica pf = new PessoaFisica();

            pf.nome = "Gustavo";

            pf.cpf = "52-52-52-52";

            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            Console.WriteLine($"CPF Validado: {pf.ValidarCPF(pf.cpf)}");

            // Pessoa Jurídica
            PessoaJuridica pj = new PessoaJuridica();

            pj.nome = "Otávio";

            Console.WriteLine(pj.DarBoasVindas(pj.nome));

            pj.cnpj = "7889-7889-7889-7889-52";

            pj.inscricaoEstadual = "52-52-52-52";

            Console.WriteLine($"CNPJ Validado: {pj.ValidarCNPJ(pj.cnpj)}");
        }
    }
}
