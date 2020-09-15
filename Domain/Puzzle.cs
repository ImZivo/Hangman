using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman.Domain
{
    public sealed class Puzzle
    {
        public Puzzle(int puzzleId, string text, IReadOnlyCollection<char> guesses, PuzzleStatus status)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Puzzle text cannot be null, empty or whitespace.", nameof(text));
            }

            PuzzleId = puzzleId;
            Text = text;
            Guesses = guesses ?? throw new ArgumentNullException(nameof(guesses));
            Status = status;
        }

        public Puzzle(int puzzleId, string text)
            : this(puzzleId, text, new char[0], PuzzleStatus.None)
        {

        }

        public int PuzzleId { get; }

        public string Text { get; }

        public IReadOnlyCollection<char> Guesses { get; }

        public PuzzleStatus Status { get; }
    }

    public static class PuzzleExtensions
    {
        public static int BadGuesses(this Puzzle @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this.Guesses
                .Select(g => @this.Text.Contains(g))
                .Where(goodGuess => !goodGuess)
                .Count();
        }
    }
}
