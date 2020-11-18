using System;

namespace Aula_18112020
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o 
            // valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            int nota;

            do {
                Console.WriteLine("Digite uma nota entre 0 e 10");
                nota = int.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10) {
                    Console.WriteLine("Digite uma nota válida, por favor!");
                }
            } while(nota < 0 || nota > 10);

            Console.WriteLine("Sua nota foi aceita, parabéns!!!");

            Console.WriteLine();

            // 2 - Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário,
            // mostrando uma mensagem de erro e voltando a pedir as informações.

            string nome;
            string senha;

            do {
                Console.WriteLine("Digite um nome de usuário: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite uma senha: ");
                senha = Console.ReadLine();

                if(nome == senha) {
                    Console.WriteLine("Digite uma senha diferente do nome, por favor!");
                }
            } while(nome == senha);

            Console.WriteLine("Sua senha foi aceita, parabéns!!!");

            Console.WriteLine();

            // 3 - Faça um programa que leia e valide as seguintes informações:

            /*
            1. Nome: diferente de vazio;
            2. Idade: entre 0 e 150;
            3. Salário: maior que zero;
            4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));
            */

            Console.WriteLine("Digite um nome sem ser vazio");
            string nome_val = Console.ReadLine();
            while (nome_val == "")
            {
                Console.WriteLine("Tente novamente");
                break;
            }

            Console.WriteLine("Digite uma idade entre 0 e 150");
            int idade_val = int.Parse(Console.ReadLine());
            while (!(idade_val >= 0 && idade_val <= 150))
            {
                Console.WriteLine("Tente novamente");
                break;
            }

            Console.WriteLine("Digite um salário maior que zero");
            float salario_val = float.Parse(Console.ReadLine());
            while (!(salario_val > 0))
            {
                Console.WriteLine("Tente novamente");
                break;
            }

            Console.WriteLine("'s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))");
            string estado_val = Console.ReadLine();
            while (!(estado_val == "s" || estado_val == "c" || estado_val == "v" || estado_val == "d"))
            {
                Console.WriteLine("Tente novamente");
                break;
            }

            // Fibonacci

            Console.WriteLine();

            int a = 1;
            int b = 1;
            Console.Write(1);
            Console.WriteLine();
            for(int i = 0;a < 377; i++) {
                b = b + a;
                a = b - a;
                Console.WriteLine(a); 
            }




        }
    }

}
