namespace Rotation.GameObjects
{
	public class VowelBox : Box
	{
		public VowelBox(char letter) : base(letter)
		{
		}

		public override int PointValue
		{
			get { return 1; }
		}
	}
}