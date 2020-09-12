using Hangman.Domain;

namespace Hangman.Service
{
    public interface IPuzzleGuessHandler
    {
        Puzzle Handle(Puzzle puzzle, string guess);
    }
}
