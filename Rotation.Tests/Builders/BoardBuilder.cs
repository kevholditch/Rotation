using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.sTests.Builders
{
	public class BoardBuilder
	{		
		public Board BuildStandard()
		{
			return new BoardFactory().Create();
		}
	}
}