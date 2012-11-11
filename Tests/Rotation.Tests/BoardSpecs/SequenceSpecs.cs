using System.Collections.Generic;
using System.Linq;
using Rotation.StandardBoard.Sequences;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs
{
	public class SequenceSpecs
	{
		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex0()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 0 for board size 9".Do(() => results = rowIndexSequence.Get(0, 9).ToList());

			"Then the sequence should contain 1 element".Observation(() => results.Count().ShouldEqual(1));

			"Then the 1st element in the sequence should be 4".Observation(() => results[0].ShouldEqual(4));
		}

		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex1()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 1 for board size 9".Do(() => results = rowIndexSequence.Get(1, 9).ToList());

			"Then the sequence should contain 3 elements".Observation(() => results.Count().ShouldEqual(3));

			"Then the 1st element in the sequence should be 3".Observation(() => results[0].ShouldEqual(3));

			"Then the 2nd element in the sequence should be 4".Observation(() => results[1].ShouldEqual(4));

			"Then the 3rd element in the sequence should be 5".Observation(() => results[2].ShouldEqual(5));
		}

		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex2()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 2 for board size 9".Do(() => results = rowIndexSequence.Get(2, 9).ToList());

			"Then the sequence should contain 5 elements".Observation(() => results.Count().ShouldEqual(5));

			"Then the 1st element in the sequence should be 2".Observation(() => results[0].ShouldEqual(2));

			"Then the 2nd element in the sequence should be 3".Observation(() => results[1].ShouldEqual(3));

			"Then the 3rd element in the sequence should be 4".Observation(() => results[2].ShouldEqual(4));

			"Then the 4th element in the sequence should be 5".Observation(() => results[3].ShouldEqual(5));

			"Then the 5th element in the sequence should be 6".Observation(() => results[4].ShouldEqual(6));
		}

		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex3()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 3 for board size 9".Do(() => results = rowIndexSequence.Get(3, 9).ToList());

			"Then the sequence should contain 7 elements".Observation(() => results.Count().ShouldEqual(7));

			"Then the 1st element in the sequence should be 1".Observation(() => results[0].ShouldEqual(1));

			"Then the 2nd element in the sequence should be 2".Observation(() => results[1].ShouldEqual(2));

			"Then the 3rd element in the sequence should be 3".Observation(() => results[2].ShouldEqual(3));

			"Then the 4th element in the sequence should be 4".Observation(() => results[3].ShouldEqual(4));

			"Then the 5th element in the sequence should be 5".Observation(() => results[4].ShouldEqual(5));

			"Then the 6th element in the sequence should be 6".Observation(() => results[5].ShouldEqual(6));

			"Then the 7th element in the sequence should be 7".Observation(() => results[6].ShouldEqual(7));
		}

		public void CanGenerateTheCorrectRowIndexSequenceForIndex4()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 4 for board size 9".Do(() => results = rowIndexSequence.Get(4, 9).ToList());

			"Then the sequence should contain 9 elements".Observation(() => results.Count().ShouldEqual(9));

			"Then the 1st element in the sequence should be 0".Observation(() => results[0].ShouldEqual(0));

			"Then the 2nd element in the sequence should be 1".Observation(() => results[1].ShouldEqual(1));

			"Then the 3rd element in the sequence should be 2".Observation(() => results[2].ShouldEqual(2));

			"Then the 4th element in the sequence should be 3".Observation(() => results[3].ShouldEqual(3));

			"Then the 5th element in the sequence should be 4".Observation(() => results[4].ShouldEqual(4));

			"Then the 6th element in the sequence should be 5".Observation(() => results[5].ShouldEqual(5));

			"Then the 7th element in the sequence should be 6".Observation(() => results[6].ShouldEqual(6));

			"Then the 8th element in the sequence should be 7".Observation(() => results[7].ShouldEqual(7));

			"Then the 9th element in the sequence should be 8".Observation(() => results[8].ShouldEqual(8));
		}

		public void CanGenerateTheCorrectRowIndexSequenceForIndex5()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 5 for board size 9".Do(() => results = rowIndexSequence.Get(5, 9).ToList());

			"Then the sequence should contain 7 elements".Observation(() => results.Count().ShouldEqual(7));

			"Then the 1st element in the sequence should be 1".Observation(() => results[0].ShouldEqual(1));

			"Then the 2nd element in the sequence should be 2".Observation(() => results[1].ShouldEqual(2));

			"Then the 3rd element in the sequence should be 3".Observation(() => results[2].ShouldEqual(3));

			"Then the 4th element in the sequence should be 4".Observation(() => results[3].ShouldEqual(4));

			"Then the 5th element in the sequence should be 5".Observation(() => results[4].ShouldEqual(5));

			"Then the 6th element in the sequence should be 6".Observation(() => results[5].ShouldEqual(6));

			"Then the 7th element in the sequence should be 7".Observation(() => results[6].ShouldEqual(7));
		}

		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex6()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 6 for board size 9".Do(() => results = rowIndexSequence.Get(6, 9).ToList());

			"Then the sequence should contain 5 elements".Observation(() => results.Count().ShouldEqual(5));

			"Then the 1st element in the sequence should be 2".Observation(() => results[0].ShouldEqual(2));

			"Then the 2nd element in the sequence should be 3".Observation(() => results[1].ShouldEqual(3));

			"Then the 3rd element in the sequence should be 4".Observation(() => results[2].ShouldEqual(4));

			"Then the 4th element in the sequence should be 5".Observation(() => results[3].ShouldEqual(5));

			"Then the 5th element in the sequence should be 6".Observation(() => results[4].ShouldEqual(6));
		}
	
		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex7()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 7 for board size 9".Do(() => results = rowIndexSequence.Get(7, 9).ToList());

			"Then the sequence should contain 3 elements".Observation(() => results.Count().ShouldEqual(3));

			"Then the 1st element in the sequence should be 3".Observation(() => results[0].ShouldEqual(3));

			"Then the 2nd element in the sequence should be 4".Observation(() => results[1].ShouldEqual(4));

			"Then the 3rd element in the sequence should be 5".Observation(() => results[2].ShouldEqual(5));
		}

		[Specification]
		public void CanGenerateTheCorrectRowIndexSequenceForIndex8()
		{
			var rowIndexSequence = default(RowIndexSequence);
			var results = default(List<int>);

			"Given that I have a row index sequence".Context(() => rowIndexSequence = new RowIndexSequence());

			"When I create a a sequence for row index 8 for board size 9".Do(() => results = rowIndexSequence.Get(8, 9).ToList());

			"Then the sequence should contain 1 element".Observation(() => results.Count().ShouldEqual(1));

			"Then the 1st element in the sequence should be 4".Observation(() => results[0].ShouldEqual(4));
		}
	}
}