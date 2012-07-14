using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.Words;
using Rotation.GameObjects.sTests.Builders;
using SubSpec;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.WordSpecs
{
    public class FoundWordSpecs
    {
        [Specification]
        public void FoundWordReturnsCorrectWordString()
        {
            var foundWord = default(FoundWord);
            var squares = default(IEnumerable<Square>);

            "Given I have a set of squares".Context(() =>

                    squares = new List<Square>
                                {
                                    BuildA.DefaultSquare().WithLetter(0, 'H').Build(),
                                    BuildA.DefaultSquare().WithLetter(0, 'O').Build(),
                                    BuildA.DefaultSquare().WithLetter(0, 'U').Build(),
                                    BuildA.DefaultSquare().WithLetter(0, 'S').Build(),
                                    BuildA.DefaultSquare().WithLetter(0, 'E').Build(),

                                }
                    );

            "When I instaniate a found word with the squares that spell house".Do(() => foundWord = new FoundWord(squares));

            "Then the word should be HOUSE".Observation(() => foundWord.Word.ShouldEqual("HOUSE"));

        }

        [Specification]
        public void FoundWordReturnsCorrectWordScore()
        {
            var foundWord = default(FoundWord);
            var squares = default(IEnumerable<Square>);

            "Given I have a set of squares".Context(() =>
            
                squares = new List<Square>
                                    {
                                        BuildA.DefaultSquare().WithLetter(6, ' ').Build(),
                                        BuildA.DefaultSquare().WithLetter(2, ' ').Build(),
                                        BuildA.DefaultSquare().WithLetter(4, ' ').Build(),
                                        BuildA.DefaultSquare().WithLetter(1, ' ').Build(),
                                        BuildA.DefaultSquare().WithLetter(7, ' ').Build(),

                                    }
            );

            "When I instaniate a found word with the squares that have a combined score of 20".Do(() => foundWord = new FoundWord(squares));

            "Then the score should be 20".Observation(() => foundWord.Score.ShouldEqual(20));

        }

    }
}
