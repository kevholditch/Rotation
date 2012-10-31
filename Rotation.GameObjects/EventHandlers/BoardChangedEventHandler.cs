using System.Collections.Generic;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.Words;

namespace Rotation.GameObjects.EventHandlers
{
    public class BoardChangedEventHandler : IGameEventHandler<BoardChangedEvent>
    {

        private readonly IWordChecker _wordChecker;
        private readonly IBoard _board;

        public BoardChangedEventHandler(IWordChecker wordChecker, IBoard board)
        {
            _wordChecker = wordChecker;
            _board = board;
        }

        public void Handle(BoardChangedEvent gameEvent)
        {
            var foundWords = new List<IWord>();
            foundWords.AddRange(_wordChecker.Check(_board.Rows));
            foundWords.AddRange(_wordChecker.Check(_board.Columns));
            
            if (foundWords.Count > 0)
                GameEvents.Raise(new WordsFoundEvent{ Words = foundWords });
        }
    }
}