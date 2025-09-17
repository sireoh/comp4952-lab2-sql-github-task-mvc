namespace TasksManagerMVC.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        public TaskItem()
        {
            IsCompleted = false;
        }

        public TaskItem(string description) : this()
        {
            Description = description;
        }
    }
}