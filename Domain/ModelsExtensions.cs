using System;

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
                BadGuesses = @this.BadGuesses,
                Status = @this.Status.ToContract()
            };
        }

        public static Contracts.PuzzleStatus ToContract(this PuzzleStatus @this) =>
            (Contracts.PuzzleStatus)(int)@this; // TODO: not sure if this works like i think
    }
}
