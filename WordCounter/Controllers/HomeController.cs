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

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string word, string sentence)
    {
      WordCounter myInput = new WordCounter(word, sentence);
      return View("Show", myInput);  
    }

  }
}