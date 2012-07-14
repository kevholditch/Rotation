using System;
using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;
using System.Linq;

namespace Rotation.GameObjects.Words
{
    public class FoundWord : IFoundWord
    {

        private readonly IEnumerable<ISquare> _squares;

        public FoundWord(IEnumerable<ISquare> squares)
        {
            _squares = squares;
        }

        private string _word;
        public string Word
        {
            get { 
                
                if (_word == null)
                    _word = new string(_squares.Select(s => s.Letter.Value).ToArray());

                return _word;

            }
        }

        
        public int Score
        {
            get { return _squares.Sum(s => s.Letter.Points); }
        }

        
    }
}