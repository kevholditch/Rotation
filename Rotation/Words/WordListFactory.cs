using System.Collections.Generic;
using System.IO;

namespace Rotation.Words
{
    public class WordListFactory : IWordListFactory
    {
        private readonly string _filename;

        public WordListFactory(string filename)
        {
            _filename = filename;
        }

        public IWordList Create()
        {
            var words = new List<string>();

            using (var streamReader = new StreamReader(_filename))
            {
                string line;
                while((line = streamReader.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            return new WordList(words);
        }
    }

    
}