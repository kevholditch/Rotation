using System;
using System.Collections.Generic;
using Rotation.GameObjects.StandardBoard;
using System.Linq;

namespace Rotation.GameObjects.Words
{
    public class Word : IWord
    {

        private readonly IEnumerable<Square> _squares;

        public Word(IEnumerable<Square> squares)
        {
            _squares = squares;
        }


        public override string ToString()
        {
            return Value;
        }

        private string _value;
        public string Value
        {
            get { 
                
                if (_value == null)
                    _value = new string(_squares.Select(s => s.Letter.Value).ToArray());

                return _value;

            }
        }

        
        public int Score
        {
            get { return _squares.Sum(s => s.Letter.Points); }
        }

        
    }
}