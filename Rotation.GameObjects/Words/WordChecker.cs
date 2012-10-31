using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.Constants;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Words
{
    public class WordChecker : IWordChecker
    {
        private readonly IWordList _wordList;

        public WordChecker(IWordListFactory wordListFactory)
        {
            _wordList = wordListFactory.Create();
        }

        public IEnumerable<IWord> Check(IEnumerable<IEnumerable<Square>> squares)
        {

            var foundWords = new List<IWord>();

            foreach (var squareList in squares)
            {
                for (int j = GameConstants.MIN_WORD_LENGTH; j <= squareList.Count(); j++)
                {
                    var words = GetWordsOfLength(squareList, j);

                    foundWords.AddRange(words.Where(w => _wordList.Words.Contains(w.ToString())));
                }
            }

            return foundWords;

        }

        private IEnumerable<IWord> GetWordsOfLength(IEnumerable<Square> squares, int length)
        {
            for (int i = 0; i + length <= squares.Count();  i++)
            {
                var currentWordSquares = squares.Skip(i).Take(length);

                if (currentWordSquares.All(s => s.CanUseInWord))
                    yield return new Word(currentWordSquares);
            }
        }

        
    }
}