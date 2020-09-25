namespace Hangman.Service.Client
open System
open System.Threading.Tasks
open Hangman.Domain

type IPuzzleRepository =
    abstract member GetRandomAsync : unit -> Task<Puzzle>
    abstract member GetAsync : puzzleId:int -> Task<Puzzle>

type PuzzleRepository() =
    interface IPuzzleRepository with
        member _this.GetRandomAsync() =
            raise (new NotImplementedException())
        member _this.GetAsync puzzleId = 
            raise (new NotImplementedException())