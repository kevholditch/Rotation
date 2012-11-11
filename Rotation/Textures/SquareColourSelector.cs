using Microsoft.Xna.Framework;
using Rotation.Engine;
using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public class SquareColourSelector : ISquareColourSelector
    {
        public Color SelectColour(Square square)
        {
            if (!square.IsSelectable)
                return DrawingConstants.SquareColours.SQUARE_NOT_SELECTABLE_COLOUR;

            if (square.IsMainSelection)
                return DrawingConstants.SquareColours.MAIN_SQUARE_SELECTED_COLOUR;

            if (square.InWord)
                return DrawingConstants.SquareColours.SQUARE_IN_WORD_COLOUR;

            return square.IsSelected
                       ? DrawingConstants.SquareColours.SQUARE_SELECTED_COLOUR
                       : DrawingConstants.SquareColours.SQUARE_NOT_SELECTED_COLOUR;

        }
    }
}