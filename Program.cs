namespace CalculadoraSimples
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("<------- Calculadora Super Simples ------->");

            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int soma = number1 + number2;
            int subtracao = number1 - number2;
            int multiplicacao = number1 * number2;
            int divisao = number1 / number2;
            int resto = number1 % number2;

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"O valor da soma é: {soma} \nO valor da subtracao é: {subtracao} \nO valor da multiplicacao é: {multiplicacao} \nO valor da divisao é: {divisao} \nO valor do resto é: {resto}");

            Console.WriteLine("<--------------------------------------->");
        }
    }
}