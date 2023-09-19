using System;

class Calculadora
{
    static void Main()
    {
        double numero1, numero2, resultado;
        char operacao;

        Console.WriteLine("============= Calculadora Simples em C# =============");
        Console.WriteLine();
        Console.Write("Digite o primeiro número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Digite o segundo número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case '-':
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case '*':
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
        Console.ReadLine(); // Aguarda uma tecla ser pressionada para encerrar o programa
    }
}
