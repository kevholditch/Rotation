using System.Linq;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.Tiles;

namespace Rotation.GameObjects.StandardBoard
{
    public class RiggedBoardFiller : IBoardFiller
    {

        private readonly ILetterLookup _letterLookup;

        public RiggedBoardFiller(ILetterLookup letterLookup)
        {
            _letterLookup = letterLookup;
        }


        public void Fill(IBoard board)
        {
            foreach (var square in board.AllSquares().Where(sq => sq.IsSelectable && !sq.HasTile))
            {
                if (square.XPos == 2 && square.YPos == 3)
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'K'));
                else if (square.XPos == 3 && square.YPos == 3)
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'E'));
                else if (square.XPos == 5 && square.YPos == 3)
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'I'));
                else if (square.XPos == 6 && square.YPos == 3)
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'N'));
                else if (square.XPos == 3 && square.YPos == 4)
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'V'));
                else
                    square.Tile = new StandardTile(_letterLookup.Letters.First(l => l.Value == 'X'));
            }
        }
    }
}