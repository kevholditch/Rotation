using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public class WordChecker : IWordChecker
    {
        private readonly IWordList _wordList;

        public WordChecker(IWordList wordList)
        {
            _wordList = wordList;
        }

        public IEnumerable<IFoundWord> Check(IEnumerable<IEnumerable<Square>> squares)
        {
            return null;
        }
    }
}