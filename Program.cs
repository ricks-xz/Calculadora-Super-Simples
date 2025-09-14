using System;

    public class Program
    {
    public static void Main()
    {

        while (true)
        {

            Console.WriteLine("------ Calculadora Simples -------\n");

            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Adição (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");

            Console.Write("Digite o número da operação desejada: ");
            dynamic operacao = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (operacao == 1)
            {
                result = num1 + num2;
                Console.WriteLine($"\n--> Resultado da soma: {result}");
            }
            else if (operacao == 2)
            {
                result = num1 - num2;
                Console.WriteLine($"\n--> Resultado da subtração: {result}");
            }
            else if (operacao == 3)
            {
                result = num1 * num2;
                Console.WriteLine($"\n--> Resultado da multiplicação: {result}");
            }
            else if (operacao == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"\n--> Resultado da divisão: {result}");
                }
                else
                {
                    Console.WriteLine("\nX Erro: Divisão por zero não é permitida. X");
                }
            }

            else
            {
                Console.WriteLine("\nX-- Operaçao inválida! --X");
            }

            Console.WriteLine("\nDeseja continuar? (s/n)");
            string continuar = Console.ReadLine();

            if (continuar?.ToLower() == "n")
            {
                Console.WriteLine("\nEncerrando a calculadora. Muito obrigado!");
                break;
            }
            else if (continuar?.ToLower() == "s")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nX-- Entrada inválida! Encerrando a calculadora. --X");
                break;
            }

        }

    }
}
