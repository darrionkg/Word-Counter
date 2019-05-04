using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class ReplaceWordsController : Controller
  {

    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string word, string sentence, string replacementWord, bool ignoreCase, bool partialWord)
    {
      ReplaceWords model = new ReplaceWords(word, sentence, replacementWord);
      if(ignoreCase == true) {
        model.SetIgnoreCaseTrue(true);
      }
      if(partialWord == true) {
        model.SetReplacePartialWordTrue(true);
      }
      return View("Show", model);
    }

    [HttpGet("/game/results")]
    public ActionResult Show()
    {
      return View();
    }
  }
}
