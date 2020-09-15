using Hangman.Domain;
using Hangman.Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Website.Controllers
{
    public sealed class GameController : Controller
    {
        public IActionResult Index()
        {
            var puzzle = new Puzzle(1, "_____");
            var model = new GameModel(puzzle);
            return View(model);
        }
    }
}
