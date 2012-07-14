using System;
using System.Linq;
using System.Text;
using Rotation.GameObjects.Words;
using Rotation.GameObjects.sTests.Extensions;
using SubSpec;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.WordSpecs
{
    public class WordListFactorySpecs
    {
        [Specification]
        public void CanCreateAWordListFromAFile()
        {
            var wordListFactory = default (WordListFactory);
            var result = default (IWordList);

            "Given I instantiated a word list factory with a list of words".Context(
                () => wordListFactory = new WordListFactory("WordSpecs/TestWordList.txt"));

            "When I call create".Do(() => result = wordListFactory.Create());

            "Then the word list should contain 4 words".Observation(() => result.Words.Count().ShouldEqual(4));

            "Then the first word should should be apples".Observation(() => result.Words.First().ShouldEqual("apples"));

            "Then the second word should be pears".Observation(() => result.Words.Second().ShouldEqual("pears"));
            
            "Then the third word should be stairs".Observation(() => result.Words.Third().ShouldEqual("stairs"));
            
            "Then the fourth word should be teddy".Observation(() => result.Words.Fourth().ShouldEqual("teddy"));

        }
    }
}
