namespace TodoApp.Models
{
    public class Todo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public TodoPriority Priority { get; set; }
        public DateTime? DueDate {  get; set; }
        public bool IsDone {  get; set; }
    }
}
