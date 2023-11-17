using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; // me class eke wada krann oni dependances tika.
using Task_API.Model;

// dark wela thiyenne thama use krala nathi dependancy tika 


/*

namespace Task_API.Controllers
{
    [Route("api/[controller]")]    // me deka class atributes. palweni eka route attribute eka api control attribute eka 
    [ApiController]
    public class TodoController : ControllerBase // API walata oni wena request, responce okkom commiunicate kranne base class eken.( ControllerBase)
    {

        /* mehema hadn na noraml. methana hadapu okkoma tika comment karmu */


// API class walata method noramaly action method kiyanwa.

/*

[HttpGet] // get type eke method ekak 

/* API waladi retrun kranne "IActionResult " ekak. wena ewa return kran na */
/*
public String[] Task()
{
    return new String[] { "task1", "task2", "task3" } ;
}
*/


/*

public IActionResult Task()
{
    var tasks = new String[] { "task1", "task2", "task3","task4" };
    return Ok(tasks);
}

[HttpPost]
public IActionResult NewTasks()
{
    return Ok();
}


[HttpPut]
public IActionResult UpdateTask()
{
    return Ok();
}


[HttpDelete]
public IActionResult DeleteTask()
{
    var somethingWentWrong = true;
    if (somethingWentWrong)
    {
        return BadRequest();
    }
    return Ok();
}


}



}


*/



namespace Task_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TodoController : ControllerBase  // API eke request response okkoma wenne base class eka haraha
    {

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)  // id eka nathwa unath data ganna puluwan
        {
            var myTodos = AllTodos();

            if (id is null) return Ok(myTodos);
           
            myTodos = myTodos.Where(t =>t.Id ==id).ToList();   // get the end point values in AllTodos list
            return Ok(myTodos);      // return the element
        }


        // GetTodos

        private List<Todo> AllTodos()  // create a list to store Todo items. list name is AllTodos
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
                    Id =2,
                    Title = "Get vegitables",
                    Description = " Get vegitables ",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.Completed

                };

                todos.Add(todo2);  




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