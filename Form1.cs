using SimpleTodoApp;  // Essa linha é essencial para que Form1.cs reconheça a classe Tarefa
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace SimpleTodoApp
{
    public partial class Form1 : Form
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string tarefa = txtTitulo.Text.Trim();

            if (!string.IsNullOrEmpty(tarefa))
            {
                int id = tarefas.Count + 1;
                tarefas.Add(new Tarefa(id, tarefa));
                AtualizarListaTarefas();
                txtTitulo.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, digite uma tarefa antes de adicionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarListaTarefas()
        {
            listBoxTarefas.Items.Clear();
            foreach (var tarefa in tarefas)
            {
                listBoxTarefas.Items.Add(tarefa);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedItem != null)
            {
                var tarefaSelecionada = listBoxTarefas.SelectedItem as Tarefa;
                string novoTitulo = txtTitulo.Text.Trim();

                if (!string.IsNullOrEmpty(novoTitulo))
                {
                    tarefaSelecionada.Titulo = novoTitulo;
                    AtualizarListaTarefas();
                    txtTitulo.Clear();
                }
                else
                {
                    MessageBox.Show("Digite um título válido para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedItem != null)
            {
                var tarefaSelecionada = listBoxTarefas.SelectedItem as Tarefa;
                tarefas.Remove(tarefaSelecionada);
                AtualizarListaTarefas();
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedItem != null)
            {
                var tarefaSelecionada = listBoxTarefas.SelectedItem as Tarefa;
                tarefaSelecionada.Concluida = true;
                AtualizarListaTarefas();
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para marcar como concluída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
