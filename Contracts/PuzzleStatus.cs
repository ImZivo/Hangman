using System.Runtime.Serialization;

namespace Hangman.Contracts
{
    [DataContract(Name = "PuzzleStatus")]
    public enum PuzzleStatus
    {
        [EnumMember(Value = "None")]
        None = 0,
        [EnumMember(Value = "Won")]
        Won = 1,
        [EnumMember(Value = "Lost")]
        Lost = 2
    }
}
