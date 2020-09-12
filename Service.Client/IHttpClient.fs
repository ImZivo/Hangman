namespace Hangman.Shared
open System

type IHttpClient =
    abstract member Get: Uri -> 'a

module HttpClientExtensions =
    type IHttpClient with
    member this.Get uri:string =
        this.Get (Uri uri)