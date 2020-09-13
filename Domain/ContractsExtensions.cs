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

            return new Puzzle(@this.PuzzleId, @this.Text, @this.Guesses, @this.Status.ToModel());
        }

        public static int ToInt(this Contracts.PuzzleStatus @this) =>
            (int)@this; // TODO: not sure if this works like i think

        public static PuzzleStatus ToModel(this Contracts.PuzzleStatus @this) =>
            (PuzzleStatus)@this.ToInt(); // TODO: not sure if this works like i think
    }
}
