namespace TaskController
{

    public enum Priority
    {
        critical = 30,
        Important = 20,
        negligible = 10
    }
    public class Task1
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duedate { get; set; }
        public Priority Level { get; set; }


        public Task1() { }


    }
}
