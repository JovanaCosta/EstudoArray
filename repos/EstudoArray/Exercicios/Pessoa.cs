namespace Exercicios
{
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public string Sobrenome { get; set; } 
        public int Idade { get; set; }
        public string CorCabelo { get; set; } 
        public int TamanhoPe { get; set; }
        public bool Estrangeira { get; set; }


        // Metodos
        public void SetNome(string nome)
        {
            Nome = nome;
        }


        public void SetSobrenome(string sobrenome)
        {
            Sobrenome = sobrenome;
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }

        public void SetCorCabelo(string corCabelo)
        {
            CorCabelo = corCabelo;
        }

        public void SetTamanhoPe(int tamanhoPe)
        {
            TamanhoPe = tamanhoPe;
        }

        public void SetEstrangeiro(bool estrangeira)
        {
            Estrangeira = estrangeira;
        }
      
    }
    
}
