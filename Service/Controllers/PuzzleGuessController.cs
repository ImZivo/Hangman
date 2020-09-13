using System;
using Hangman.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Service.Controllers
{
    [Route(Paths.Api.Puzzles)]
    [ApiController]
    public sealed class PuzzleGuessController : ControllerBase
    {
        [HttpGet("{id}/guess/{guess}")]
        public Contracts.Puzzle Get(
            [FromRoute] int id,
            [FromRoute] char guess,
            [FromBody] Contracts.Puzzle puzzle)
        {
            // TODO: calculate

            throw new NotImplementedException();
        }
    }
}