namespace Exercicios
{
    public class CalculosService
    {
        //1- Criar o metodo chamado "CalculandoMaiorNumero" recebendo por parametro 4 numeros
        //2- me dizer qual dos 4 é o maior 

        public void Main(int numero1, int numero2, int numero3, int numero4, int numero5)
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

            //menor
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
           
        //print
    }



}

