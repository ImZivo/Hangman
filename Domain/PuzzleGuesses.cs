using System;
using System.Collections.Generic;

namespace Hangman.Domain
{
    public sealed class PuzzleGuesses
    {
        public PuzzleGuesses(int puzzleId, IReadOnlyCollection<char> guesses)
        {
            PuzzleId = puzzleId;
            Guesses = guesses ?? throw new ArgumentNullException(nameof(guesses));
        }

        public int PuzzleId { get; }

        public IReadOnlyCollection<char> Guesses { get; }
    }
}
