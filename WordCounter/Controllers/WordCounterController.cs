using Microsoft.AspNetCore.Mvc;
using WordApp.Models;

namespace WordApp.Controllers
{
  public class WordCounterController : Controller
  {

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