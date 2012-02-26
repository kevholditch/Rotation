using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public interface IRowIndexSequenceGenerator
	{
		IEnumerable<int> Create(int start, int length);
	}
}