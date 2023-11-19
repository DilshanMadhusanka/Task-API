namespace Task_API.Model
{
    public class Todo  // create a todo class
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Due { get; set;}
        public TodoStatus Status { get; set; } // New , Inprogress , Completed ( me tika dala class ekak hadala thiyenne , typing krankot erros enn puluwan nisa)
    }
    
}
