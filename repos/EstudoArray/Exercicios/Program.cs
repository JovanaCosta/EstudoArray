using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Encontre o maior dentre 3 números: ");

        // Numeros fornecidos diretamente no código
        int numero1 = 65465;
        int numero2 = 64658;
        int numero3 = 65464;

        // Exibe os Numeros
        Console.WriteLine($"Primeiro número: {numero1}");
        Console.WriteLine($"Segundo número: {numero2}");
        Console.WriteLine($"Terceiro número: {numero3}");

        // Determina o maior número
        int maior = numero1;

        if(numero2 > maior)
        {
            maior = numero2;
        }

        if (numero3 > maior) 
        {
            maior = numero3;
        }

        // Mostra o resultado final
        Console.WriteLine ($"\nO maior número é: {maior}");
    }
}
