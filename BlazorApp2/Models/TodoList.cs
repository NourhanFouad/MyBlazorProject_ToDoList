namespace BlazorApp2.Models
{
    public class TodoList
    {
        public int id { get; set; }
        public string name { get; set; }
        public string   ? note  { get; set; }
        public DateTime Dueto { get; set; }= DateTime.Today;
        public bool?  isCompleted { get; set; }= false;
        public Category? category { get; set; }
        public Priority priority { get; set; }= Priority.Low;

    }

    public enum Category
    {
        Work,
        Personal,
        Shopping,
        Others
    }

    public enum Priority
    {
        Low=0,
        Important=1
    }

}

