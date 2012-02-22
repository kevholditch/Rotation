namespace Rotation.GameObjects.Boxes
{
	public class EasyConsonant : Box
	{
		internal EasyConsonant(char letter) : base(letter)
		{
		}

		public override int PointValue
		{
			get { return 2; }
		}
	}
}