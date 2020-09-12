namespace Hangman.Service.Client
open System

type IHttpClient =
    abstract member Get: Uri -> 'a

module HttpClientExtensions =
    type IHttpClient with
    member this.Get uri =
        this.Get (Uri uri)