using demolab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace demolab1.Controllers
{
    public class Lab1Controller1 : Controller
    {
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End game Programming",
                CourseCode = "GAME106",
                Name = "LÊ QUANG LÂM",
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
