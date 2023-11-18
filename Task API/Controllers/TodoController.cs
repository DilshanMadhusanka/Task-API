using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; // me class eke wada krann oni dependances tika.

using Task_API.Services;



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

        private TodoServices _todoServices;

        public TodoController()
        {
            _todoServices = new TodoServices();
        }



        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)  // id eka nathwa unath data ganna puluwan
        {
       

        var myTodos = _todoServices.AllTodos();

            if (id is null) return Ok(myTodos); // nul value ekak awoth return wenna
           
            myTodos = myTodos.Where(t =>t.Id ==id).ToList();   // get the end point values in AllTodos list ( id ekat galapen value tika wiharak return kranna )
            return Ok(myTodos);      // return the element
        }


        // GetTodos

        // methana thibuna set eka TodoServices class file ekat damma

       
    }


}