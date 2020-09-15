using System.Runtime.Serialization;

namespace Hangman.Contracts
{
    [DataContract(Name = "PuzzleGuesses")]
    public sealed class PuzzleGuesses : IExtensibleDataObject
    {
        [DataMember(Name = "PuzzleId", Order = 0)]
        public int PuzzleId { get; set; }

        [DataMember(Name = "Guesses", Order = 1)]
        public char[] Guesses { get; set; } = null!;

        ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; } = null!;
    }
}
