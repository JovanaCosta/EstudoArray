namespace Exercicios
{
    public class Exemplo
    {
        public void Execute(int numero1, int numero2, int numero3)
        {
            Calculando(numero1, numero2, numero3);
            Calculando2(numero1);
        }

        public void Calculando(int numero1, int numero2, int numero3)
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
        }

        public void Calculando2(int numero1)
        {
            // Printa no console
            Console.WriteLine($"Primeiro numero é: {numero1}");
        }
    }
}
