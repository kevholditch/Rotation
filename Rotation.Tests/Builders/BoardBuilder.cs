using Rotation.GameObjects.Board;

namespace Rotation.GameObjects.sTests.Builders
{
	public class BoardBuilder
	{		
		public IBoard BuildStandard()
		{
			return new BoardFactory().Create();
		}
	}
}