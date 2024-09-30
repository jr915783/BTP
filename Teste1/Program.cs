/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string alfanumérica: ");
            string input = Console.ReadLine();
            string result = RemoveValuesDuplicates(input);
            Console.WriteLine($"Valor retornado sem duplicação: {result}");            
        }

        static string RemoveValuesDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Você digitou um valor inválido.";

            char[] chars = input.ToCharArray();
            string output = chars[0].ToString();

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != chars[i - 1])
                {
                    output += chars[i];
                }
            }

            return output;
        }
    }
}