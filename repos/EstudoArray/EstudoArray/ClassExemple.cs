namespace EstudoArray
{
    public class ClassExemple
    {
        // Atributos da classe

        public int Atributo1 { get; set; }
        public string Atributo2 { get; set; }


        // Contrutor
        public ClassExemple()
        {

        }

        // Contrutor com parametro
        public ClassExemple(int atributo1, string atributo2)
        {
            Atributo1 = atributo1;
            Atributo2 = atributo2;
        }



        // Metodo sem retorno (void)
        public void NomeMetodo()
        {

        }

        // Metodo com retorno
        public int NomeMetodo2()
        {
            return 1;
        }

        // Metodo com parametros de entrada
        public void NomeMetodo3(int parametro1, string parametro2)
        {

        }


        // ******* Exemplos Gerais *******

        public void PrintandoLista(int[] meuArray)
        {
            foreach (var numero in meuArray)
            {
                // Mostrando/Printando no Console 
                Console.WriteLine(numero);
            }
        }

        public void ExecuteArray()
        {
            //Criando array com 10 posicoes
            var meuArray = new int[10];

            //Adicionando valores no array
            meuArray[0] = 22;
            meuArray[1] = 17;
            meuArray[2] = 13;

            for (int i = 0; i < 10; i++)
            {
                if (meuArray[i] == 22)
                {
                    // Removendo do array
                    meuArray[i] = 0;
                }
            }

            //Chamando outro metodo
            PrintandoLista(meuArray);
        }

    }
}
