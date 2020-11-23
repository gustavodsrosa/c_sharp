using System;

namespace Aula_20112020
{
    class Program
    {   

        static float CalculoMedia(float [] numeros) {
            float soma = 0;
            for(var i = 0; i < numeros.Length; i++) {
                soma += numeros[i];
            }
            float resultado = soma / numeros.Length;

            return resultado;
        }
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

            string[] nomes = new string[5];
            float[] medias = new float[5];
            float[] notas = new float[4];
            

            for(int i = 0; i < nomes.Length; i++) {
                Console.WriteLine("Digite um nome de aluno: ");
                nomes[i] = Console.ReadLine();

                for(int c = 0; c < notas.Length; c++) {
                    Console.WriteLine($"Digite a {c+1}° nota");
                    notas[c] = float.Parse(Console.ReadLine());
                }

                medias[i] = CalculoMedia(notas);

                int x = 0;
                if(medias[i] >= 7) {
                    Console.WriteLine($"{x+1} aprovado(s)");
                } else {
                    Console.WriteLine($"{x+1} reprovado(s)");
                }
            }

            foreach(string nome in nomes) {
                Console.WriteLine(nome);
            }

            for(int i = 0; i < nomes.Length; i++) {
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Média: " + medias[i]);
            }

            

            Console.WriteLine();
            Console.WriteLine("Media geral " + CalculoMedia(medias));

            
            
        }
    } 
}


