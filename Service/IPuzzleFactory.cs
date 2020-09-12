using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangman.Domain;

namespace Hangman.Service
{
    public interface IPuzzleFactory
    {
        Puzzle Create();

        Puzzle Create(int puzzleId);
    }
}
