namespace Rotation.GameObjects.Factories
{
	public class StandardBoxFactory : IBoxFactory
	{
		public Box Create()
		{
			return new StandardBox('B');
		}
	}
}