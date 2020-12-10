using System;
namespace POO_Polimorfismo
{
    public class MegaMan : Player
    {
        public override void Correr() {
            Console.WriteLine("Correndo em velocidade 100x");
        }
    }
}