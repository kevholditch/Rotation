using System;
using System.Collections.Generic;
using Rotation.GameObjects.Board;
using SubSpec;
using System.Linq;

namespace Xunit.BoardSpecs
{
	public class LineIndexGeneratorSpecs
	{
		private LineIndexSequenceGenerator _sequenceGenerator;
		private List<int> _results;
		private Exception _exception;

		[Specification]
		public void CanGenerateALineIndexOfLength1()
		{
			"Given that I have a sequence generator".Context(() => _sequenceGenerator = new LineIndexSequenceGenerator());

			"When I generate a sequence of length 1".Do(() => _results = _sequenceGenerator.Create(1).ToList());

			"Then the sequence should be of length 1".Observation(() => _results.Count.ShouldEqual(1));

			"The first item in the sequence should be 0".Observation(() => _results[0].ShouldEqual(0));
		}

		[Specification]
		public void CanGenerateALineIndexOfLength3()
		{
			"Given that I have a sequence generator".Context(() => _sequenceGenerator = new LineIndexSequenceGenerator());

			"When I generate a sequence of length 3".Do(() => _results = _sequenceGenerator.Create(3).ToList());

			"Then the sequence should be of length 3".Observation(() => _results.Count.ShouldEqual(3));

			"The first item in the sequence should be 0".Observation(() => _results[0].ShouldEqual(0));

			"The second item in the sequence should be 1".Observation(() => _results[1].ShouldEqual(1));

			"The third item in the sequence should be 0".Observation(() => _results[2].ShouldEqual(0));
		}

		[Specification]
		public void CanGenerateALineIndexOfLength5()
		{
			"Given that I have a sequence generator".Context(() => _sequenceGenerator = new LineIndexSequenceGenerator());

			"When I generate a sequence of length 5".Do(() => _results = _sequenceGenerator.Create(5).ToList());

			"Then the sequence should be of length 5".Observation(() => _results.Count.ShouldEqual(5));

			"The first item in the sequence should be 0".Observation(() => _results[0].ShouldEqual(0));

			"The second item in the sequence should be 1".Observation(() => _results[1].ShouldEqual(1));

			"The third item in the sequence should be 2".Observation(() => _results[2].ShouldEqual(2));

			"The fourth item in the sequence should be 1".Observation(() => _results[3].ShouldEqual(1));

			"The fifth item in the sequence should be 0".Observation(() => _results[4].ShouldEqual(0));
		}

		[Specification]
		public void CanGenerateALineIndexOfLength7()
		{
			"Given that I have a sequence generator".Context(() => _sequenceGenerator = new LineIndexSequenceGenerator());

			"When I generate a sequence of length 7".Do(() => _results = _sequenceGenerator.Create(7).ToList());

			"Then the sequence should be of length 7".Observation(() => _results.Count.ShouldEqual(7));

			"The first item in the sequence should be 0".Observation(() => _results[0].ShouldEqual(0));

			"The second item in the sequence should be 1".Observation(() => _results[1].ShouldEqual(1));

			"The third item in the sequence should be 2".Observation(() => _results[2].ShouldEqual(2));

			"The fourth item in the sequence should be 3".Observation(() => _results[3].ShouldEqual(3));

			"The fifth item in the sequence should be 2".Observation(() => _results[4].ShouldEqual(2));

			"The sixth item in the sequence should be 1".Observation(() => _results[5].ShouldEqual(1));

			"The seventh item in the sequence should be 0".Observation(() => _results[6].ShouldEqual(0));
		}

		[Specification]
		public void CannotGenerateASequenceWithAnEvenLength()
		{
			"Given that I have a sequence generator".Context(() => _sequenceGenerator = new LineIndexSequenceGenerator());

			"When I generate a sequence of length 2".Do(() => _exception =  Record.Exception(() => _sequenceGenerator.Create(2).ToList()));

			"Then the exception should be of type ArgumentException".Observation(
				() => _exception.ShouldBeOfType<ArgumentException>());


		}
	}
}