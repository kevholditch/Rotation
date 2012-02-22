namespace Rotation.GameObjects.Boxes
{
	public class Letter
	{
		public Letter(int points, char value)
		{
			Points = points;
			Value = value;
		}

		public int Points { get; set; }
		public char Value { get; set; }

		public bool IsVowel
		{
			get { return Value == 'A' || Value == 'E' || Value == 'I' || Value == 'O' || Value == 'U'; }

		}
	}

}