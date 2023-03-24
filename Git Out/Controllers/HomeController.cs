using Git_Out.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Git_Out.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Gabby" });
        }
    }
}