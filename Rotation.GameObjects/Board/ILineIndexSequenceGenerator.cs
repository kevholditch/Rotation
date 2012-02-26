using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public interface ILineIndexSequenceGenerator
	{
		IEnumerable<int> Create(int length);
	}
}