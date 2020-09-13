namespace Hangman.Shared
open System

module public Alphabet =
    let LowercaseLetters =
        ['a'..'z']
        |> List.toSeq
    let UppercaseLetters =
        LowercaseLetters
        |> Seq.map Char.ToUpper