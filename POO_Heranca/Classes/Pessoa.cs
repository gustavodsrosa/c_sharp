namespace POO_Heranca.Classes {

    public class Pessoa {
        public string nome;

        public string DarBoasVindas(string nome_usuario) {
            return $"Boas-vindas, {nome_usuario}";
        }
    }
}