using System;
using Hangman.Domain;

namespace Hangman.Website.Models
{
    public sealed class GameModel
    {
        public GameModel(Puzzle puzzle)
        {
            Puzzle = puzzle ?? throw new ArgumentNullException(nameof(puzzle));
        }

        public Puzzle Puzzle { get; }
    }
}
