using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/play")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/play/result")]
        public ActionResult PlayGame()
        {
          RepeatCounter newGame = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
          int count = newGame.CountRepeatWords();
          newGame.SetWordCount(count);
          return View("Result",newGame);
        }
    }
}
