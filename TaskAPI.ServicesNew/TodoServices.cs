using Task_API.Model;

namespace Task_API.Services
{
    public class TodoServices
    {
      public List<Todo> AllTodos()  // create a list to store Todo items. list name is AllTodos
        {
            var todos = new List<Todo>();  // create an object 
            {


                var todo1 = new Todo   // create an item 
                {
                    Id = 1,
                    Title = "Get books for the school",
                    Description = " Get some books for the school library",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New

                };

                todos.Add(todo1);  // add item to todos list


                var todo2 = new Todo
                {
                    Id = 2,
                    Title = "Get vegitables",
                    Description = " Get vegitables ",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.Completed

                };

                todos.Add(todo2);  // add the elemnt to the todos list




                var todo3 = new Todo
                {
                    Id = 3,
                    Title = "Get water",
                    Description = " Get water for the school library",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(4),
                    Status = TodoStatus.New

                };

                todos.Add(todo3);
            }

            return todos;  // return the list 
        }
    }
}
