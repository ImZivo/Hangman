using System;
using System.Linq;

namespace Hangman.Domain
{
    public sealed class Puzzle
    {
        public Puzzle(int puzzleId, string text, PuzzleStatus status)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Puzzle text cannot be null, empty or whitespace.", nameof(text));
            }

            PuzzleId = puzzleId;
            Text = text;
            Status = status;
        }

        public Puzzle(int puzzleId, string text)
            : this(puzzleId, text, PuzzleStatus.None)
        {

        }

        public int PuzzleId { get; }

        public string Text { get; }

        public PuzzleStatus Status { get; }
    }
}
