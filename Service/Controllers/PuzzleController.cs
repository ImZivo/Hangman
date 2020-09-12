using System;
using Hangman.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Service.Controllers
{
    [Route(Paths.Api.Puzzles)]
    [ApiController]
    public sealed class PuzzleController : ControllerBase
    {
        [HttpGet]
        public Contracts.Puzzle Get()
        {
            // TODO: get random new puzzle

            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Contracts.Puzzle Get([FromRoute] string id) // this could be string, id, whatever... but it needs to be a primitive
        {
            // TODO: get puzzle based on ID

            throw new NotImplementedException();
        }

        [HttpGet("{id}/{guess}")]
        public Contracts.Puzzle Get(
            [FromRoute] string id, // this could be string, id, whatever... but it needs to be a primitive
            [FromRoute] string guess,
            [FromBody] Contracts.Puzzle puzzle)
        {
            // TODO: calculate

            throw new NotImplementedException();
        }
    }
}