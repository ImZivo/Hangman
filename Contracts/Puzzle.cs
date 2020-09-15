﻿using System.Runtime.Serialization;

namespace Hangman.Contracts
{
    [DataContract(Name = "Puzzle")]
    public sealed class Puzzle : IExtensibleDataObject
    {
        [DataMember(Name = "PuzzleId", Order = 0)]
        public int PuzzleId { get; set; }

        [DataMember(Name = "Text", Order = 1)]
        public string Text { get; set; } = null!;

        [DataMember(Name = "Status", Order = 2)]
        public PuzzleStatus Status { get; set; }

        ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; } = null!;
    }
}
