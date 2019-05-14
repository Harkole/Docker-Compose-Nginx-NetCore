using Microsoft.AspNetCore.Mvc;

namespace app
{
    public class HelloController : Controller
    {
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}