using Rotation.GameObjects.Board;

namespace Rotation.Tests.Builders
{
	public class BoardBuilder
	{		
		public IBoard BuildStandard()
		{
			return new BoardFactory().Create();
		}
	}
}