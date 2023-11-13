using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; // me class eke wada krann oni dependances tika.

                                // dark wela thiyenne thama use krala nathi dependancy tika 

namespace Task_API.Controllers
{
    [Route("api/[controller]")]    // me deka class atributes. palweni eka route attribute eka api control attribute eka 
    [ApiController]
    public class TaskController : ControllerBase // API walata oni wena request, responce okkom commiunicate kranne base class eken.( ControllerBase)
    {
        // API class walata method noramaly action method kiyanwa.



        [HttpGet] // get type eke method ekak 
        public String[] Task()
        {
            return new String[] { "task1", "task2", "task3" };
        }
    }
}
