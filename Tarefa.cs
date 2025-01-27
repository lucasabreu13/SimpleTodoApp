namespace SimpleTodoApp
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            Concluida = false;
        }

        public override string ToString()
        {
            return $"{Id}. {Titulo} - {(Concluida ? "Concluída" : "Pendente")}";
        }
    }
}
