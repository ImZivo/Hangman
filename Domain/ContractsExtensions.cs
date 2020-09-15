using System;

namespace Hangman.Domain
{
    public static class ContractsExtensions
    {
        public static Puzzle ToModel(this Contracts.Puzzle @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new Puzzle(@this.PuzzleId, @this.Text, @this.Status.ToModel());
        }

        public static PuzzleGuesses ToModel(this Contracts.PuzzleGuesses @this)
        {
            if (@this is null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return new PuzzleGuesses(@this.PuzzleId, @this.Guesses);
        }

        public static int ToInt(this Contracts.PuzzleStatus @this) =>
            (int)@this;

        public static PuzzleStatus ToModel(this Contracts.PuzzleStatus @this) =>
            (PuzzleStatus)@this.ToInt();
    }
}
