using System;
using Hangman.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Service.Controllers
{
    [Route(Paths.Api.Puzzles)]
    [ApiController]
    public sealed class PuzzleGuessController : ControllerBase
    {
        [HttpGet("{id}/guess")]
        public Contracts.Puzzle Get(
            [FromRoute] int id,
            [FromBody] Contracts.PuzzleGuesses puzzle)
        {
            // TODO: calculate

            throw new NotImplementedException();
        }
    }
}