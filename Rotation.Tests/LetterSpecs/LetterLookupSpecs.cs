using System.Linq;
using Rotation.GameObjects.Boxes;
using SubSpec;
using Xunit;

namespace Rotation.Tests.LetterSpecs
{
	public class LetterLookupSpecs
	{
		private ILetterLookup _letterLookup = null;

		[Specification]
		public void CheckThatAllOfTheAlphabetExists()
		{

			"Given that I have a letter lookup interface".Context(() => _letterLookup = null);

			"When I create a default instance of the letter lookup interface".Do(() => _letterLookup = new LetterLookup());

			"Then I should have 26 letters".Observation(() => Assert.Equal(26, _letterLookup.Letters.Count()));

			"Then each letter should only exist once".Observation(
				() => Assert.Equal(26, _letterLookup.Letters.GroupBy(l => l.Value).Count()));


		}
	}
}