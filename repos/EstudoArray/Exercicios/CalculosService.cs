using System.Runtime.Serialization;

namespace Exercicios
{
    public class CalculosService
    {
        // SOLID
        // S - Unica Responsabilidade
        public void Execute(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            CalcularMaiorNumero(numero1, numero2, numero3, numero4, numero5);
            CalcularMenorNumero(numero1, numero2, numero3, numero4, numero5);

            var resultadoSomaNumero = SomaDosNumeros(numero1, numero5);

            SubtrairOsNumeros(numero1, numero3);

            var listaNumeros = new List<int>();
            listaNumeros.Add(numero1);
            listaNumeros.Add(numero2);
            listaNumeros.Add(numero4);

            var listaOrdenada = OrdenandoDeFormaCrescente(listaNumeros);
            PrintLista(listaOrdenada);
        }

        private void PrintLista(List<int> listaOrdenada)
        {
            foreach (var numero in listaOrdenada)
            {
                Console.WriteLine(numero);
            }
        }

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

        public int SomaDosNumeros(int numero1, int numero5)
        {
            int resultado = numero1 + numero5;

            Console.WriteLine($"A soma é :{resultado}");

            return resultado;
        }

        public void SubtrairOsNumeros(int numero1, int numero3)
        {
            int resultado = numero1 - numero3;

            Console.WriteLine($"A subtração é : {resultado}");
        }

        public List<int> OrdenandoDeFormaCrescente(List<int> listNumeros)
        {
            listNumeros.Sort();
            return listNumeros;
        }

    }
}
