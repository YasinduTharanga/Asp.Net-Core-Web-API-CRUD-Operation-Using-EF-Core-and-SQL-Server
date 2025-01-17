using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string GetGreering()
        {
            return "Hello there!";
        }
        //CRUD
        //Create - a new record - POST
        //Read - retieve a single/ listof record(s) - GET
        //Update - modify an exisitng record - PUT
        //Delete - remove an exisiting record - DELETE
    }
}
