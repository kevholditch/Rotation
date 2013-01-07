using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.StandardBoard;

namespace Rotation.Textures
{
    public class SquareColourSelector : ISquareColourSelector
    {
        public Color SelectColour(Square square)
        {
            if (!square.IsSelectable)
                return DrawingConstants.SquareColours.SQUARE_NOT_SELECTABLE_COLOUR;

            if (square.IsInBlock)
                return DrawingConstants.SquareColours.SQUARE_IN_BLOCK_COLOUR;

            Color colour;

            if (square.Colour == 0)
                colour = DrawingConstants.SquareColours.SQUARE_COLOUR_0;
            else if (square.Colour == 1)
                colour = DrawingConstants.SquareColours.SQUARE_COLOUR_1;
            else
                colour = DrawingConstants.SquareColours.SQUARE_COLOUR_2;

            //if (square.IsSelected)
            //{

            //    var hslColor = new HSLColor(colour.R, colour.G, colour.B);
            //    hslColor.Luminosity += 40;
            //    colour = hslColor;
            //}

            return colour;

        }
    }

}