using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Hangman.Domain
{
    public static class ModelsExtensions
    {
        public static Contracts.Puzzle ToContract(this Puzzle @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new Contracts.Puzzle()
            {
                PuzzleId = @this.PuzzleId,
                Text = @this.Text,
                Status = @this.Status.ToContract()
            };
        }

        public static Contracts.PuzzleGuesses ToContract(this PuzzleGuesses @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new Contracts.PuzzleGuesses()
            {
                PuzzleId = @this.PuzzleId,
                Guesses = @this.Guesses.ToArray()
            };
        }

        public static int ToInt(this PuzzleStatus @this) =>
            (int)@this;

        public static Contracts.PuzzleStatus ToContract(this PuzzleStatus @this) =>
            (Contracts.PuzzleStatus)@this.ToInt();
    }
}
