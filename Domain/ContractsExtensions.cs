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

            return new Puzzle(@this.PuzzleId, @this.Text, @this.BadGuesses, @this.Status.ToModel());
        }

        public static PuzzleStatus ToModel(this Contracts.PuzzleStatus @this) =>
            (PuzzleStatus)(int)@this; // TODO: not sure if this works like i think
    }
}
