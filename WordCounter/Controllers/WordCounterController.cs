using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpPost("/result")]
        public ActionResult Result()
        {
          RepeatCounter newGame = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
          int count = newGame.CountRepeatWords();
          newGame.SetWordCount(count);
          return View("Index", newGame);
        }


    }
}
