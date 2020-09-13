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
        public Contracts.Puzzle Get([FromRoute] int id)
        {
            // TODO: get puzzle based on ID

            throw new NotImplementedException();
        }
    }
}