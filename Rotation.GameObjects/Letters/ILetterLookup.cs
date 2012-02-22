using System.Collections.Generic;

namespace Rotation.GameObjects.Boxes
{
	public interface ILetterLookup
	{
		IEnumerable<Letter> Letters { get; }
	}
}