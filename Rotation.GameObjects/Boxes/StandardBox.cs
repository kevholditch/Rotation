namespace Rotation.GameObjects.Boxes
{
	public class StandardBox : Box
	{
		internal StandardBox(char letter) : base (letter)
		{		
		}

		public override int PointValue
		{
			get { return 3; }
		}
	}
}