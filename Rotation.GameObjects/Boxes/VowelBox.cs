namespace Rotation.GameObjects.Boxes
{
	public class VowelBox : Box
	{
		internal VowelBox(char letter) : base(letter)
		{
		}

		public override int PointValue
		{
			get { return 1; }
		}
	}
}