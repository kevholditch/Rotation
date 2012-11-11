using System.Collections.Generic;

namespace Rotation.Words
{
    public class WordList : IWordList
    {
        private readonly IEnumerable<string> _words;

        public WordList(IEnumerable<string> words)
        {
            _words = words;
        }

        public IEnumerable<string> Words
        {
            get { return _words; }
        }
    }
}