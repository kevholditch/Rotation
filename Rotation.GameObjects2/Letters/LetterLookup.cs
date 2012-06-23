using System.Collections.Generic;
using System.Linq;

namespace Rotation.GameObjects.Letters
{
	public class LetterLookup : ILetterLookup
	{

		private IEnumerable<Letter> _letters;

		public LetterLookup()
		{
			_letters = new List<Letter>
			           	{
			           		new Letter(1, 'A'),
			           		new Letter(3, 'B'),
			           		new Letter(4, 'C'),
			           		new Letter(2, 'D'),
			           		new Letter(1, 'E'),
			           		new Letter(4, 'F'),
			           		new Letter(3, 'G'),
			           		new Letter(3, 'H'),
			           		new Letter(1, 'I'),
			           		new Letter(10, 'J'),
			           		new Letter(5, 'K'),
			           		new Letter(2, 'L'),
			           		new Letter(4, 'M'),
			           		new Letter(2, 'N'),
			           		new Letter(1, 'O'),
			           		new Letter(4, 'P'),
			           		new Letter(10, 'Q'),
			           		new Letter(2, 'R'),
			           		new Letter(1, 'S'),
			           		new Letter(1, 'T'),
			           		new Letter(1, 'U'),
			           		new Letter(4, 'V'),
			           		new Letter(3, 'W'),
			           		new Letter(8, 'X'),
			           		new Letter(4, 'Y'),
			           		new Letter(10, 'Z')
			           	}.AsEnumerable();
		}

		public IEnumerable<Letter> Letters
		{
			get { return _letters; }
		}
	}
}