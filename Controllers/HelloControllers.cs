using System;
using Microsoft.AspNetCore.Mvc;
namespace dojo_survey.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("method")]
        public IActionResult method(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
        }
    }
}