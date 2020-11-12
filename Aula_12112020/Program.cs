using System;

namespace Aula_12112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 - Atividade Material do Dia
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine();
    
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            double media = (nota1+nota2+nota3)/3;

            Console.WriteLine();

            Console.WriteLine("A média entre os dois números é de: " + media);

            Console.WriteLine();

            if(media > 5){
                Console.WriteLine("Você foi aprovado(a), " + nomeAluno);
            } else {
                Console.WriteLine("Você foi reprovado(a), " + nomeAluno );
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Exercício 2 - Atividade da Aula
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            string nomeDoAluno = Console.ReadLine();

            Console.WriteLine();
    
            Console.WriteLine("Digite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double media2 = (n1+n2)/2;

            Console.WriteLine("A média entre os dois números é de: " + media2);

            Console.WriteLine();

            if(media > 7){
                Console.WriteLine("Você foi aprovado(a), " + nomeDoAluno);
            } else {
                Console.WriteLine("Você foi reprovado(a), " + nomeDoAluno );
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            // Exercício 3 - Semáforos e Carros
            Console.WriteLine("Qual a cor do semáforo?");
            string CorSemaforo = Console.ReadLine();

            Console.WriteLine();

            if(CorSemaforo == "Verde" | CorSemaforo == "verde" | CorSemaforo == "VERDE") {
                Console.WriteLine("Mantenha a velocidade e prossiga");
            } else if(CorSemaforo == "Amarelo" | CorSemaforo == "amarelo" | CorSemaforo == "AMARELO") {
                Console.WriteLine("Evite freada brusca, diminua a velocidade e pare o veículo");
            } else if(CorSemaforo == "Vermelho" | CorSemaforo == "vermelho" | CorSemaforo == "VERMELHO") {
                Console.WriteLine("Pare imediatamente o veículo");
            } else {
                Console.WriteLine("Cor do semáforo incorreta, tente novamente");
            }
        }
    }
}
