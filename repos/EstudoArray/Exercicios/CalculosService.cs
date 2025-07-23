namespace Exercicios
{
    public class CalculosService
    {
        //1- Criar o metodo chamado "CalculandoMaiorNumero" recebendo por parametro 4 numeros
        //2- me dizer qual dos 4 é o maior 

        /* 3- Criar 2 metodos separados
                Um para calcular o maior numero chamado CalcularMaiorNumero
                Outro para calcular o menor numero chamado CalcularMenorNumero
        */

        // SOLID
        // S - Unica Responsabilidade

        public void CalcularMaiorNumero(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            int maior = numero1;

            if (numero2 > maior)
            {
                maior = numero2;
            }
            if (numero3 > maior)
            {
                maior = numero3;
            }
            if (numero4 > maior)
            {
                maior = numero4;
            }
            if (numero5 > maior)
            {
                maior = numero5;
            }

            Console.WriteLine($" O maior numero é: {maior}");
        }

        public void CalcularMenorNumero(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            int menor = numero1;
            if (numero2 < menor)
            {
                menor = numero2;
            }
            if (numero3 < menor)
            {
                menor = numero3;
            }
            if (numero4 < menor)
            {
                menor = numero4;

            }
            if (numero5 < menor)
            {
                menor = numero5;
            }
            Console.WriteLine($"O menor número é {menor}");
        }

        public void Execute(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            CalcularMaiorNumero(numero1, numero2, numero3, numero4, numero5);
            CalcularMenorNumero(numero1, numero2, numero3, numero4, numero5);

            //Calcule qual é a soma do numero1 e numero5
            // e print
        }

        

    }
}

