using Microsoft.AspNetCore.Mvc;
using WordApp.Models;

namespace WordApp.Controllers
{
    public class HomeController : Controller
    {

    [HttpGet("/")]
    public ActionResult Index()
    {
      WordCounter starterItem = new WordCounter("Add first item to To Do List", "Hello");
      return View(starterItem);
    }
   }
}      