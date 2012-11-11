using System.Collections.Generic;

namespace Rotation.Letters
{
	public interface ILetterLookup
	{
		IEnumerable<Letter> Letters { get; }
	}
}