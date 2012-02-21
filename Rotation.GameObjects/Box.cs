using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rotation.GameObjects
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
