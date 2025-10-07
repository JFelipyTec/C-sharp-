using System;
using System.Collections.Generic;

class GerenciadorDeTarefas
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine("====== GERENCIADOR DE TAREFAS ======");
            Console.WriteLine($"Total de tarefas: {tarefas.Count}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Remover tarefa");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa(tarefas);
                    break;

                case "2":
                    ListarTarefas(tarefas);
                    break;

                case "3":
                    RemoverTarefa(tarefas);
                    break;

                case "4":
                    Console.WriteLine("Encerrando o programa. Até logo!");
                    executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AdicionarTarefa(List<string> tarefas)
    {
        Console.Clear();
        Console.Write("Digite o nome da tarefa: ");
        string novaTarefa = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(novaTarefa))
        {
            Console.WriteLine("Tarefa inválida! Pressione Enter para voltar ao menu.");
        }
        else if (tarefas.Contains(novaTarefa.Trim()))
        {
            Console.WriteLine("Tarefa já cadastrada! Pressione Enter para voltar ao menu.");
        }
        else
        {
            tarefas.Add(novaTarefa.Trim());
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        Console.WriteLine("Pressione Enter para continuar.");
        Console.ReadLine();
    }

    static void ListarTarefas(List<string> tarefas)
    {
        Console.Clear();
        Console.WriteLine("====== LISTA DE TAREFAS ======");

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }

        Console.WriteLine("Pressione Enter para voltar ao menu.");
        Console.ReadLine();
    }

    static void RemoverTarefa(List<string> tarefas)
    {
        Console.Clear();
        Console.WriteLine("====== REMOVER TAREFA ======");

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa para remover.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }

            Console.Write("Digite o número da tarefa que deseja remover: ");
            string input = Console.ReadLine();
            int numero;

            if (int.TryParse(input, out numero) && numero >= 1 && numero <= tarefas.Count)
            {
                string tarefaRemovida = tarefas[numero - 1];
                tarefas.RemoveAt(numero - 1);
                Console.WriteLine($"Tarefa \"{tarefaRemovida}\" removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        Console.WriteLine("Pressione Enter para voltar ao menu.");
        Console.ReadLine();
    }
}
