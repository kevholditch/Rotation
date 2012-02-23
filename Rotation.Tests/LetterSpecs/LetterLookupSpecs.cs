using System.Linq;
using Rotation.GameObjects.Letters;
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

			"Then I should have 26 letters".Observation(() => _letterLookup.Letters.Count().ShouldEqual(26));

			"Then each letter should only exist once".Observation(
				() => _letterLookup.Letters.GroupBy(l => l.Value).Count().ShouldEqual(26));


		}
	}
}