namespace Hangman.Service.Client
open System.Threading.Tasks
open Hangman.Domain

type IPuzzleRepository =
    abstract member GetRandomAsync : unit -> Task<Puzzle>
    abstract member GetAsync : puzzleId:int -> Task<Puzzle>

type PuzzleRepository() =
    interface IPuzzleRepository with
        member _this.GetRandomAsync() =
            async {
                return new Puzzle(1, "TODO: finish implementation")
            } |> Async.StartAsTask
        member _this.GetAsync puzzleId = 
            async {
                return new Puzzle(puzzleId, "TODO: finish implementation")
            } |> Async.StartAsTask