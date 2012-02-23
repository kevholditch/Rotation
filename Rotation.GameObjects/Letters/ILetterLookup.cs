using System.Collections.Generic;

namespace Rotation.GameObjects.Letters
{
	public interface ILetterLookup
	{
		IEnumerable<Letter> Letters { get; }
	}
}