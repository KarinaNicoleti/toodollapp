// ----------------------------------------------
// 📝 Projeto: ToodollApp
// 💻 Criado por: Karina Nicoleti
// 📅 Data: 21/10/2025
// ----------------------------------------------
// Este programa é o ponto de partida do ToodollApp,
// um sistema simples para gerenciamento de tarefas.
// Aqui apenas exibimos uma mensagem de boas-vindas
// para o usuário no console.
// ----------------------------------------------
using System;
using System.Collections.Generic; // precisa disso pra usar List<>

class Tarefa
{
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }
}

class Program
{
    static void Main()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n📝 Bem-vinda ao ToodollApp!");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar como concluída");
            Console.WriteLine("4. Remover tarefa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string novaDescricao = Console.ReadLine() ?? "";

                    if (!string.IsNullOrEmpty(novaDescricao))
                    {
                        tarefas.Add(new Tarefa(novaDescricao));
                        Console.WriteLine("✅ Tarefa adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("🚫 Tarefa inválida. Tente novamente.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\n📋 Lista de Tarefas:");
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa adicionada ainda.");
                    }
                    else
                    {
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            string status = tarefas[i].Concluida ? "[✔]" : "[ ]";
                            Console.WriteLine($"{i + 1}. {status} {tarefas[i].Descricao}");
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("\n📌 Qual tarefa deseja marcar como concluída?");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = tarefas[i].Concluida ? "[✔]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i].Descricao}");
                    }

                    Console.Write("Digite o número da tarefa: ");
                    string entradaIndice = Console.ReadLine() ?? "";
                    if (int.TryParse(entradaIndice, out int indice) && indice >= 1 && indice <= tarefas.Count)
                    {
                        tarefas[indice - 1].Concluida = true;
                        Console.WriteLine("✅ Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("🚫 Número inválido.");
                    }
                    break;

                case "4":
                    Console.WriteLine("⚠️ Essa função ainda será implementada.");
                    break;

                case "5":
                    Console.WriteLine("👋 Saindo...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("🚫 Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
