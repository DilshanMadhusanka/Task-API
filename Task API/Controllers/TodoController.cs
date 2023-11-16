using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; // me class eke wada krann oni dependances tika.

                                // dark wela thiyenne thama use krala nathi dependancy tika 

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
  */

    }



}
