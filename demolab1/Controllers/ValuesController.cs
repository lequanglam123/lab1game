using demolab1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demolab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End game Programming",
                CourseCode = "GAME106",
                Name = "LE QUANG LAM",
                StudentCode = "PD11008",
                Class = "GA19301",
            };
            int status = 1;
            string massage = "Get data sucess!";
            var data = new { status, massage, game106 };
            return new JsonResult(game106);
        }
    }
}
