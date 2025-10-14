using System;

namespace CalculadoraCompleta
{
    // Classe Calculadora métodos para cada operação
    public class Calculadora
    {
        // soma
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // subtração
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        // multiplicação
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // divisão com alerta de divisão por zero
        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return a / b;
        }

        // potenciação
        public double Potenciar(double baseNum, double expoente)
        {
            return Math.Pow(baseNum, expoente);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(); // Instancia da calculadora
            bool continuar = true;

            Console.WriteLine("=== CALCULADORA EM C# ===");

            // Laço principal para repetir até o usuário decidir sair
            while (continuar)
            {
                try
                {
                    // Exibe o menu de opções
                    Console.WriteLine("\nEscolha a operação:");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Potenciação");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Opção: ");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 0)
                    {
                        continuar = false;
                        Console.WriteLine("Encerrando a calculadora...");
                        break;
                    }

                    // Solicita os números ao usuário
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    // Estrutura de decisão para escolher a operação
                    switch (opcao)
                    {
                        case 1:
                            resultado = calc.Somar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 2:
                            resultado = calc.Subtrair(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 3:
                            resultado = calc.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 4:
                            resultado = calc.Dividir(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        case 5:
                            resultado = calc.Potenciar(num1, num2);
                            Console.WriteLine($"Resultado: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Entrada inválida. Digite apenas números.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }

            Console.WriteLine("Obrigado por usar a calculadora!");
        }
    }
}
