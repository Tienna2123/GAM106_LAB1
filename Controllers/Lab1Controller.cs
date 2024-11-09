using LAB1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            GAM106Model game106 = new GAM106Model
            {
                CourseName = "Game Development",
                CourseCode = "GAM106",
                Name = "John Doe",
                StudentCode = "123456",
                Class = "A"
            };
            int status = 1;
            string message = "Get data sucsses!";
            var data = new { status, message, game106 };
            return new JsonResult(game106);
        }
    }
}
