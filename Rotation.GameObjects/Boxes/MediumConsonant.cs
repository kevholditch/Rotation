namespace Rotation.GameObjects.Boxes
{
	public class MediumConsonant : Box
	{
		internal MediumConsonant(char letter) : base(letter)
		{
		}

		public override int PointValue
		{
			get { return 5; }
		}
	}
}