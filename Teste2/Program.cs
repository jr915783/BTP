/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                Console.Write("Por favor digite um número entre 1 e 19:"); 
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 0 && number < 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Você digitou um valor inválido.");
                }
            }

            var fibonacciSequence = CreateSequenceFibonacci(number);
            Console.WriteLine($"Fibonacci para {number} termos: {string.Join(", ", fibonacciSequence)}");


            static int[] CreateSequenceFibonacci(int count)
            {
                int[] fibonacci = new int[count];

                if (count >= 1) fibonacci[0] = 1;
                if (count >= 2) fibonacci[1] = 1;

                for (int i = 2; i < count; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                return fibonacci;
            }
        }
    }
}