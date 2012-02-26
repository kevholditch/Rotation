using System;
using System.Collections.Generic;
using Rotation.GameObjects.Board;
using SubSpec;
using System.Linq;

namespace Xunit.BoardSpecs
{
	public class RowIndexSequenceGeneratorSpecs
	{
		private RowIndexSequenceGenerator _sequenceGenerator;
		private List<int> _results;
		private Exception _exception;

		[Specification]
		public void CanGenerateARowIndexSequenceOf1()
		{
			"Given that I have a row index sequence generator".Context(() => _sequenceGenerator = new RowIndexSequenceGenerator());

			"When I create a sequence of start 4 and length 1".Do(() => _results = _sequenceGenerator.Create(4, 1).ToList());

			"Then I should get a sequence of length 1".Observation(() => _results.Count.ShouldEqual(1));

			"Then first item in the sequence should be 4".Observation(() => _results[0].ShouldEqual(4));	

		}

		[Specification]
		public void CanGenerateARowIndexSequenceOf3()
		{
			"Given that I have a row index sequence generator".Context(() => _sequenceGenerator = new RowIndexSequenceGenerator());

			"When I create a sequence of start 4 and length 3".Do(() => _results = _sequenceGenerator.Create(4, 3).ToList());

			"Then I should get a sequence of length 3".Observation(() => _results.Count.ShouldEqual(3));

			"Then first item in the sequence should be 3".Observation(() => _results[0].ShouldEqual(3));

			"Then second item in the sequence should be 4".Observation(() => _results[1].ShouldEqual(4));

			"Then third item in the sequence should be 5".Observation(() => _results[2].ShouldEqual(5));
		}

		[Specification]
		public void CanGenerateARowIndexSequenceOf5()
		{
			"Given that I have a row index sequence generator".Context(() => _sequenceGenerator = new RowIndexSequenceGenerator());

			"When I create a sequence of start 4 and length 3".Do(() => _results = _sequenceGenerator.Create(4, 5).ToList());

			"Then I should get a sequence of length 5".Observation(() => _results.Count.ShouldEqual(5));

			"Then first item in the sequence should be 2".Observation(() => _results[0].ShouldEqual(2));

			"Then second item in the sequence should be 3".Observation(() => _results[1].ShouldEqual(3));

			"Then third item in the sequence should be 4".Observation(() => _results[2].ShouldEqual(4));

			"Then fourth item in the sequence should be 5".Observation(() => _results[3].ShouldEqual(5));

			"Then fifth item in the sequence should be 6".Observation(() => _results[4].ShouldEqual(6));
		}

		[Specification]
		public void CannotGenerateAListOfEvenLength()
		{
			"Given that I have a row index sequence generator".Context(() => _sequenceGenerator = new RowIndexSequenceGenerator());

			"When I create a sequence of start 4 and length 2".Do(() => _exception = Record.Exception(() => _sequenceGenerator.Create(4, 2).ToList()));

			"Then I should get an ArgumentException".Observation(() => _exception.ShouldBeOfType<ArgumentException>());
		}

	}
}