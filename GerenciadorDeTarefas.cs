using System;
using System.Collections.Generic;

public class GerenciadorDeTarefas
{
    private List<Tarefa> _tarefas = new List<Tarefa>(); // Lista de tarefas
    private int _proximoId = 1; // ID para a próxima tarefa

    // Método para adicionar uma nova tarefa
    public void AdicionarTarefa(string titulo)
    {
        var novaTarefa = new Tarefa(_proximoId++, titulo); // Cria uma nova tarefa
        _tarefas.Add(novaTarefa); // Adiciona a tarefa à lista
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    // Método para listar todas as tarefas
    public void ListarTarefas()
    {
        Console.WriteLine("\nTarefas:");
        if (_tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            foreach (var tarefa in _tarefas)
            {
                Console.WriteLine(tarefa); // Usa o método ToString para mostrar a tarefa
            }
        }
    }

    // Método para editar uma tarefa existente
    public void EditarTarefa(int id, string novoTitulo)
    {
        var tarefa = _tarefas.Find(t => t.Id == id); // Encontra a tarefa pelo ID
        if (tarefa != null)
        {
            tarefa.Titulo = novoTitulo; // Atualiza o título
            Console.WriteLine("Tarefa editada com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    // Método para remover uma tarefa
    public void RemoverTarefa(int id)
    {
        var tarefa = _tarefas.Find(t => t.Id == id); // Encontra a tarefa pelo ID
        if (tarefa != null)
        {
            _tarefas.Remove(tarefa); // Remove a tarefa da lista
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    // Método para marcar a tarefa como concluída
    public void MarcarComoConcluida(int id)
    {
        var tarefa = _tarefas.Find(t => t.Id == id); // Encontra a tarefa pelo ID
        if (tarefa != null)
        {
            tarefa.Concluida = true; // Marca como concluída
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
}
