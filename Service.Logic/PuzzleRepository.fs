namespace Hangman.Service.Client
open System.Threading.Tasks
open Hangman.Domain

type IPuzzleRepository =
    abstract member GetRandomAsync : Task<Puzzle>
    abstract member GetAsync : puzzleId:int -> Task<Puzzle>