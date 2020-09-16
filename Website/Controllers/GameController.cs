using System;
using System.Linq;
using Hangman.Domain;
using Hangman.Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Website.Controllers
{
    public sealed class GameController : Controller
    {
        private readonly (int Id, string Text)[] Solutions =
        {
            (1, "ALPHABETICAL"),
            (2, "PUZZLE"),
            (3, "FORGERY"),
            (4, "FACTORY"),
            (5, "CHALLENGE")
        };

        public IActionResult Index()
        {
            var rand = new Random();
            var puzzleId = rand.Next(1, 6);
            var puzzleText = Solutions.Single(s => s.Id == puzzleId).Text;
            var puzzle = new Puzzle(puzzleId, String.Join(String.Empty, Enumerable.Repeat("_", puzzleText.Length)));
            var model = new GameModel(puzzle);
            return View(model);
        }

        public Contracts.Puzzle Guess(Contracts.PuzzleGuesses puzzle)
        {
            var solutionText = Solutions.Single(s => s.Id == puzzle.PuzzleId).Text;
            var solutionLetters = solutionText.Distinct();
            var currentPuzzle = solutionText;

            foreach (var letter in solutionLetters)
            {
                if (!puzzle.Guesses.Contains(letter))
                {
                    currentPuzzle = currentPuzzle.Replace(letter, '_');
                }
            }

            return new Contracts.Puzzle()
            {
                PuzzleId = puzzle.PuzzleId,
                Text = currentPuzzle,
                Status = !currentPuzzle.Contains('_')
                    ? Contracts.PuzzleStatus.Won
                    : Contracts.PuzzleStatus.None
            };
        }
    }
}
