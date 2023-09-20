using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;



using WordPuzzle.Models;

namespace WordPuzzle.Controllers 
{   
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      GameState newGame = new GameState();

      return View(newGame);
    }
  }
}