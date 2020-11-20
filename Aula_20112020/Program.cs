using System;

namespace Aula_20112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 

            /*
            Faça um programa que receba o nome e quatro notas de dez alunos e armazene essas notas em vetores.
            Calcule e mostre:

            a) Média do aluno (Função);
            b) Quantidade de aprovados (Media >= 7);
            c) Quantidade de reprovados (Média <= 7);
            d) Média geral dos 10 alunos
            */

            string[] nomes = new string[10];
            float[] nota1 = new float[4];
            float[] nota2 = new float[4];
            float[] nota3 = new float[4];
            float[] nota4 = new float[4];
            float[] media = new float[4];

            for(var i = 0; i < 10; i++) {
                Console.WriteLine("Digite o nome do aluno: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite a nota: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota: ");
                nota4[i] = float.Parse(Console.ReadLine());

                media[i] = ((nota1[i] + nota2[i] + nota3[i] + nota4[i])/4 );
                }
            } 
        }
    }

