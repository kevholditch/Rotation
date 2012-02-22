namespace Rotation.GameObjects.Boxes
{
	public class VeryHardConsonant : Box
	{
		internal VeryHardConsonant(char letter) : base(letter)
		{
		}


		public override int PointValue
		{
			get { return 8; }
		}
	}
}