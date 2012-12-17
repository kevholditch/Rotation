using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rotation.Blocks;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.BlockSpecs
{
    public class BlockFinderSpecs
    {
        [Specification]
        public void CanFindASingleBlock()
        {
            var results = default(IEnumerable<Block>);
            var board = default(IBoard);
            var blockFinder = default(BlockFinder);

            "Given I have a board that contains one block".Context(() =>
            {
                board = new BoardFactory().Create();
                var boardFillerOneBlock = new BoardFillerOneBlock();
                boardFillerOneBlock.Fill(board);
                blockFinder = new BlockFinder();
            });

            "When I find blocks".Do(() => results = blockFinder.Find(board));

            "Then 1 block should be returned"
                .Observation(() => results.Count().ShouldEqual(1));

            "Then 1 square should be at 3, 1"
                .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 1).ShouldEqual(1));
            
            "Then 1 square should be at 4, 1"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 1).ShouldEqual(1));

            "Then 1 square should be at 3, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square should be at 4, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 2).ShouldEqual(1));


        }

        [Specification]
        public void CanFindMultipleBlocksInDifferentPartsOfGrid()
        {
            var results = default(IEnumerable<Block>);
            var board = default(IBoard);
            var blockFinder = default(BlockFinder);

            "Given I have a board that contains two blocks".Context(() =>
            {
                board = new BoardFactory().Create();
                var boardFillerTwoBlocks = new BoardFillerTwoBlocks();
                boardFillerTwoBlocks.Fill(board);
                blockFinder = new BlockFinder();
            });

            "When I find blocks".Do(() => results = blockFinder.Find(board));

            "Then 2 blocks should be returned"
                .Observation(() => results.Count().ShouldEqual(2));

            "Then 1 square in the first block should be at 3, 1"
                .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 1).ShouldEqual(1));

            "Then 1 square in the first block should be at 4, 1"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 1).ShouldEqual(1));

            "Then 1 square in the first block should be at 3, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the first block should be at 4, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the second block should be at 3, 6"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 3 && s.YPos == 6).ShouldEqual(1));

            "Then 1 square in the second block should be at 4, 6"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 4 && s.YPos == 6).ShouldEqual(1));

            "Then 1 square in the second block should be at 3, 7"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 3 && s.YPos == 7).ShouldEqual(1));

            "Then 1 square in the second block should be at 4, 7"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 4 && s.YPos == 7).ShouldEqual(1));

            
        }


        [Specification]
        public void CanFindOverLappingBlocks()
        {
            var results = default(IEnumerable<Block>);
            var board = default(IBoard);
            var blockFinder = default(BlockFinder);

            "Given I have a board that contains two blocks".Context(() =>
            {
                board = new BoardFactory().Create();
                var boardFillerTwoOverlappingBlocks = new BoardFillerTwoOverlappingBlocks();
                boardFillerTwoOverlappingBlocks.Fill(board);
                blockFinder = new BlockFinder();
            });

            "When I find blocks".Do(() => results = blockFinder.Find(board));

            "Then 2 blocks should be returned"
                .Observation(() => results.Count().ShouldEqual(2));

            "Then 1 square in the first block should be at 3, 1"
                .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 1).ShouldEqual(1));

            "Then 1 square in the first block should be at 4, 1"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 1).ShouldEqual(1));

            "Then 1 square in the first block should be at 3, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 3 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the first block should be at 4, 2"
               .Observation(() => results.First().Squares.Count(s => s.XPos == 4 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the second block should be at 4, 2"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 4 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the second block should be at 5, 2"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 5 && s.YPos == 2).ShouldEqual(1));

            "Then 1 square in the second block should be at 4, 3"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 4 && s.YPos == 3).ShouldEqual(1));

            "Then 1 square in the second block should be at 5, 3"
               .Observation(() => results.ToList()[1].Squares.Count(s => s.XPos == 5 && s.YPos == 3).ShouldEqual(1));

            
        }

        [Specification]
        public void CanDetectWhenThereAreNoBlocksPresent()
        {
            var results = default(IEnumerable<Block>);
            var board = default(IBoard);
            var blockFinder = default(BlockFinder);

            "Given I have a board that contains no blocks".Context(() =>
                {
                    board = new BoardFactory().Create();
                    var numericalBoardFiller = new NumericalBoardFiller();
                    numericalBoardFiller.Fill(board);
                    blockFinder = new BlockFinder();
                });

            "When I find blocks".Do(() => results = blockFinder.Find(board));

            "Then no blocks should be returned"
                .Observation(() => results.Count().ShouldEqual(0));
        }
    }

    public class BoardFillerOneBlock : IBoardFiller
    {
        public void Fill(IBoard board)
        {
            var numericalBoardFiller = new NumericalBoardFiller();
            numericalBoardFiller.Fill(board);

            board[3, 1].Tile = new TestTile(2);
            board[4, 1].Tile = new TestTile(2);
            board[3, 2].Tile = new TestTile(2);
            board[4, 2].Tile = new TestTile(2);
        }
    }

    public class BoardFillerTwoBlocks : IBoardFiller
    {
        public void Fill(IBoard board)
        {
            var numericalBoardFiller = new NumericalBoardFiller();
            numericalBoardFiller.Fill(board);

            board[3, 1].Tile = new TestTile(2);
            board[4, 1].Tile = new TestTile(2);
            board[3, 2].Tile = new TestTile(2);
            board[4, 2].Tile = new TestTile(2);

            board[3, 6].Tile = new TestTile(2);
            board[4, 6].Tile = new TestTile(2);
            board[3, 7].Tile = new TestTile(2);
            board[4, 7].Tile = new TestTile(2);
        }
    }

    public class BoardFillerTwoOverlappingBlocks : IBoardFiller
    {
        public void Fill(IBoard board)
        {
            var numericalBoardFiller = new NumericalBoardFiller();
            numericalBoardFiller.Fill(board);

            board[3, 1].Tile = new TestTile(2);
            board[4, 1].Tile = new TestTile(2);
            board[3, 2].Tile = new TestTile(2);
            board[4, 2].Tile = new TestTile(2);

            board[4, 3].Tile = new TestTile(2);
            board[5, 2].Tile = new TestTile(2);
            board[5, 3].Tile = new TestTile(2);
        }
    }
}
