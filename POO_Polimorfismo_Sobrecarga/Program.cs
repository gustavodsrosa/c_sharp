using System;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Mostrar();
            funcionario.Mostrar("Gustavo");
            funcionario.Mostrar(2);

            Console.WriteLine();
            Console.Beep();
        }
    }
}
