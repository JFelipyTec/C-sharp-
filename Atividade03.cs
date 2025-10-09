using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int escolha;

        do
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1 - Contador Personalizado");
            Console.WriteLine("2 - Calculadora Simples");
            Console.WriteLine("3 - Lista de Nomes");
            Console.WriteLine("4 - Funções no Dia a Dia");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            switch (escolha)
            {
                case 1:
                    ContadorPersonalizado();
                    break;
                case 2:
                    CalculadoraSimples();
                    break;
                case 3:
                    ListaDeNomes();
                    break;
                case 4:
                    FuncoesNoDiaADia();
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (escolha != 5);
    }

    /*
     * Atividade 01 – Contador Personalizado
     */
    static void ContadorPersonalizado()
    {
        Console.WriteLine("\n--- Contador Personalizado ---");

        Console.Write("Digite o número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        int fim = int.Parse(Console.ReadLine());

        Console.Write("Deseja mostrar apenas os números pares? (s/n): ");
        string somentePares = Console.ReadLine().ToLower();

        if (inicio <= fim)
        {
            for (int i = inicio; i <= fim; i++)
            {
                if (somentePares == "s")
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            for (int i = inicio; i >= fim; i--)
            {
                if (somentePares == "s")
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    /*
     * Atividade 02 – Calculadora Simples
     */
    static void CalculadoraSimples()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n--- Calculadora Simples ---");
            Console.WriteLine("1 – Soma");
            Console.WriteLine("2 – Subtração");
            Console.WriteLine("3 – Multiplicação");
            Console.WriteLine("4 – Divisão");
            Console.WriteLine("5 – Voltar ao Menu Principal");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                            Console.WriteLine("Erro: divisão por zero.");
                        else
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        break;
                }
            }
            else if (opcao != 5)
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }

    /*
     * Atividade 03 – Lista de Nomes
     */
    static void ListaDeNomes()
    {
        Console.WriteLine("\n--- Lista de Nomes ---");
        List<string> nomes = new List<string>();
        string entrada;

        while (true)
        {
            Console.Write("Digite um nome (ou 'sair' para encerrar): ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
                break;

            if (!string.IsNullOrWhiteSpace(entrada))
                nomes.Add(entrada);
        }

        Console.WriteLine($"\nTotal de nomes cadastrados: {nomes.Count}");

        nomes.Sort();

        Console.WriteLine("\nNomes em ordem alfabética:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    /*
     * Atividade 04 – Funções no Dia a Dia
     */
    static void FuncoesNoDiaADia()
    {
        Console.WriteLine("\n--- Funções no Dia a Dia ---");
        ExibirMenuFuncao();

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Saudacao(nome);

        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        double resultado = Somar(n1, n2);
        Console.WriteLine($"A soma dos números é: {resultado}");

        // Verificação de Par ou Ímpar
        Console.Write("\nDigite um número inteiro para verificar se é par ou ímpar: ");
        int numero = int.Parse(Console.ReadLine());
        VerificarParOuImpar(numero);
    }

    // Funções auxiliares da Atividade 04
    static void ExibirMenuFuncao()
    {
        Console.WriteLine("Este é um exemplo de programa com funções.");
    }

    static void Saudacao(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");
    }

    static double Somar(double a, double b)
    {
        return a + b;
    }

    static void VerificarParOuImpar(int numero)
    {
        if (numero % 2 == 0)
            Console.WriteLine($"O número {numero} é PAR.");
        else
            Console.WriteLine($"O número {numero} é ÍMPAR.");
    }
}
