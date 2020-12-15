namespace POO_Construct.Classes
{
    public class Pessoa
    {
        public string primeiroNome;
        public string sobreNome;
        public Pessoa() {

        }
        public Pessoa(string primeiroNome, string sobreNome) {
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;

            System.Console.WriteLine($"Bem-vindo {primeiroNome} {sobreNome}");
        }
    }
}