using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class ReplaceWordsController : Controller
  {

    // "/game" - Homescreen wit special options buttons

    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string word, string sentence, string replacementWord)
    {
      ReplaceWords model = new ReplaceWords(word, sentence, replacementWord);
      return View("Show", model);
    }

    [HttpGet("/game/results")]
    public ActionResult Show()
    {

      return View();
    }
  }
}
