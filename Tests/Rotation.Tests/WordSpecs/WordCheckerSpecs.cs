using System.Collections.Generic;
using FakeItEasy;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.Words;
using Rotation.Tests.Common.Builders;
using SubSpec;
using System.Linq;
using Rotation.Tests.Common;

namespace Rotation.GameObjects.sTests.WordSpecs
{
    public class WordCheckerSpecs
    {
        [Specification]
        public void DoesntReturnAWordIfItsNotInSquaresWhereAWordCanBeMade()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain a word in a region that cannot be used to make a word".
                Context(() =>
                            {
                                var wordList = A.Fake<IWordList>();
                                A.CallTo(() => wordList.Words).Returns(new[] {"HOUSE"});

                                wordChecker = new WordChecker(wordList);
                                squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(false)
                                                            .WithLetter(0, 'H').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(false)
                                                            .WithLetter(0, 'O').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(false)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(false)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(false)
                                                            .WithLetter(0, 'E').Build()
                                                      }
                                              };
                            });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then no words should be returned".Observation(() => result.Count().ShouldEqual(0));


        }

        [Specification]
        public void DoesReturnAWordIfIsInSquaresWhereAWordCanBeMade()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain a word in a region that can be used to make a word".
                Context(() =>
                {
                    var wordList = A.Fake<IWordList>();
                    A.CallTo(() => wordList.Words).Returns(new[] { "HOUSE" });

                    wordChecker = new WordChecker(wordList);
                    squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'H').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'O').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build()
                                                      }
                                              };
                });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then 1 word should be returned".Observation(() => result.Count().ShouldEqual(1));

            "Then the word returned should be HOUSE".Observation(() => result.First().Value.ShouldEqual("HOUSE"));

        }

        [Specification]
        public void CanFindTwoWordsInAListOfSquares()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain two words".
                Context(() =>
                {
                    var wordList = A.Fake<IWordList>();
                    A.CallTo(() => wordList.Words).Returns(new[] { "HOUSE", "CARD" });

                    wordChecker = new WordChecker(wordList);
                    squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'H').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'O').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),

                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'C').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'A').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'R').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'D').Build(),
                                                      }
                                              };
                });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then 2 words should be returned".Observation(() => result.Count().ShouldEqual(2));

            "Then the word HOUSE should be returned".Observation(() => result.Count(r => r.Value == "HOUSE").ShouldEqual(1));

            "Then the word CARD should be returned".Observation(() => result.Count(r => r.Value == "CARD").ShouldEqual(1));

        }

        [Specification]
        public void CanFindTwoWordsThatOverlapInAListOfSquares()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain two words".
                Context(() =>
                {
                    var wordList = A.Fake<IWordList>();
                    A.CallTo(() => wordList.Words).Returns(new[] { "HOUSE", "SEED" });

                    wordChecker = new WordChecker(wordList);
                    squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'H').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'O').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),

                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'D').Build()
                                                      }
                                              };
                });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then 2 words should be returned".Observation(() => result.Count().ShouldEqual(2));

            "Then the word HOUSE should be returned".Observation(() => result.Count(r => r.Value == "HOUSE").ShouldEqual(1));

            "Then the word SEED should be returned".Observation(() => result.Count(r => r.Value == "SEED").ShouldEqual(1));

        }

        [Specification]
        public void CanFindTwoWordsInTwoDifferentLists()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain two words in two lists".
                Context(() =>
                {
                    var wordList = A.Fake<IWordList>();
                    A.CallTo(() => wordList.Words).Returns(new[] { "HOUSE", "SEED" });

                    wordChecker = new WordChecker(wordList);
                    squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'H').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'O').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build()
                                                      },
                                                 new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'S').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'D').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build()
                                                      }
                                              };
                });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then 2 words should be returned".Observation(() => result.Count().ShouldEqual(2));

            "Then the word HOUSE should be returned".Observation(() => result.Count(r => r.Value == "HOUSE").ShouldEqual(1));

            "Then the word SEED should be returned".Observation(() => result.Count(r => r.Value == "SEED").ShouldEqual(1));

        }

        [Specification]
        public void NoWordsAreReturnedWhenSquaresDontContainAnyMatchingWords()
        {
            var squares = default(IEnumerable<IEnumerable<Square>>);
            var wordChecker = default(WordChecker);
            var result = default(IEnumerable<IWord>);

            "Given I have a collection of squares that contain no words".
                Context(() =>
                {
                    var wordList = A.Fake<IWordList>();
                    A.CallTo(() => wordList.Words).Returns(new[] { "HOUSE", "SEED" });

                    wordChecker = new WordChecker(wordList);
                    squares = new List<List<Square>>
                                              {
                                                  new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'X').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'U').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'Z').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'Y').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build()
                                                      },
                                                 new List<Square>()
                                                      {
                                                          BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'A').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'D').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'F').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'E').Build(),
                                                            BuildA.DefaultSquare()
                                                            .WithCanUseInWord(true)
                                                            .WithLetter(0, 'A').Build()
                                                      }
                                              };
                });

            "When I call check".Do(() => result = wordChecker.Check(squares));

            "Then no words should be returned".Observation(() => result.Count().ShouldEqual(0));

           
        }
    }
}