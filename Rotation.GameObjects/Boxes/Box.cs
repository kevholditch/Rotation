namespace Rotation.GameObjects.Boxes
{
	public abstract class Box
	{
		protected Box(char letter)
		{
			Letter = letter;
		}


		public abstract int PointValue { get; }
		public char Letter { get; private set; }
	}
}
