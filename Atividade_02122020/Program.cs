using System;

namespace Atividade_02122020.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do curso: ");
            aluno.curso = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RG do aluno: ");
            aluno.rg = Console.ReadLine();

            Console.WriteLine("O aluno é bolsista??: ");
            string resposta = Console.ReadLine();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            if (resposta.ToLower() == "s") {
                aluno.bolsista  = true; 
            } else if (resposta.ToLower() == "n"){
                aluno.bolsista  = false; 
            }

            Console.WriteLine("Insira a média do aluno: ");
            aluno.mediaFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor da mensalidade: ");
            aluno.valorDaMensalidade = double.Parse(Console.ReadLine());

            aluno.VerMediaFinal(aluno.mediaFinal);
            aluno.VerMensalidade(aluno.bolsista, aluno.valorDaMensalidade);
            
        }
    }
}
