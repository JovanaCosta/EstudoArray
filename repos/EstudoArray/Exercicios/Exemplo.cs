namespace Exercicios
{
    public class Exemplo
    {
        public int CalculandoMaiorNumero(int numero1, int numero2, int numero3)
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

            // Printa no console
            Console.WriteLine($"O maior número é: {maior}");

            return maior;
        }
    }
}
