namespace Exercicios
{
    public class PessoaService
    {
        public void Execute()
        {
            //chamar todos os metodos da classe Pessoa
            var pessoaService = new Pessoa();

            pessoaService.SetNome("Joao");
            pessoaService.SetSobrenome("Souza");
            pessoaService.SetIdade(25);
            pessoaService.SetCorCabelo("Castanho");
            pessoaService.SetTamanhoPe(36);
            pessoaService.SetEstrangeiro(true);
        }
    }
}
                                                                                                                                                      