namespace Rotation.GameObjects.Boxes
{
	public class HardConsonant : Box
	{
		internal HardConsonant(char letter) : base(letter)
		{
		}

		public override int PointValue
		{
			get { return 5; }
		}
	}
}