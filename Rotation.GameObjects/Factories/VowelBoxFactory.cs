using System;
using System.Collections.Generic;

namespace Rotation.GameObjects.Factories
{
	public class VowelBoxFactory : IBoxFactory
	{

		private Dictionary<int, char> _vowels;

		public VowelBoxFactory()
		{
			_vowels = new Dictionary<int, char> {{0, 'A'}, {1, 'E'}, {2, 'I'}, {3, 'O'}, {4, 'U'}};
		}

		public Box Create()
		{
			var random = new Random((int)DateTime.Now.Ticks);

			return new VowelBox(_vowels[random.Next(0, 4)]);
		}
	}
}