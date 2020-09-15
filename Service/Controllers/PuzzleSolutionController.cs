using System;
using Hangman.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Hangman.Service.Controllers
{
    [Route(Paths.Api.Puzzles)]
    [ApiController]
    public sealed class PuzzleSolutionController : ControllerBase
    {
        [HttpGet("{id}/solution")]
        public Contracts.Puzzle Get([FromRoute] int id) // TODO: not sure if we should reuse this contract
        {
            // TODO: get puzzle solution based on ID

            throw new NotImplementedException();
        }
    }
}