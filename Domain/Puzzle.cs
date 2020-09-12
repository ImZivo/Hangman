using System;

namespace Hangman.Domain
{
    public sealed class Puzzle
    {
        public Puzzle(int puzzleId, string text, int badGuesses, PuzzleStatus status)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Puzzle text cannot be null, empty or whitespace.", nameof(text));
            }

            PuzzleId = puzzleId;
            Text = text;
            BadGuesses = badGuesses;
            Status = status;
        }

        public int PuzzleId { get; }

        public string Text { get; }

        public int BadGuesses { get; }

        public PuzzleStatus Status { get; }
    }
}
