using System.Collections.Generic;
using System.IO;

namespace Rotation.GameObjects.Words
{
    public class WordListFactory : IWordListFactory
    {

        private readonly string filename;

        public WordListFactory(string filename)
        {
            this.filename = filename;
        }

        public IWordList Create()
        {
            var words = new List<string>();

            using (var streamReader = new StreamReader(filename))
            {
                var line = "";
                while((line = streamReader.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            return new WordList(words);
        }
    }
}