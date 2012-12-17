using Microsoft.Xna.Framework;

namespace Rotation.Engine
{
    public static class DrawingConstants
    {
        public static class Tiles
        {
            public const string NON_TILE = "TileNon";
            public const string STANDARD_TILE = "StandardTile";
            public const string BLANK_TILE = "TileBlank";
            public const int TILE_WIDTH = 40;
            public const int TILE_HEIGHT = 40;
        }

        public static class Board
        {
            public const int BOARD_X_MARGIN = 10;
            public const int BOARD_Y_MARGIN = 10;
        }

        public static class SquareColours
        {
            public static readonly Color SQUARE_SELECTED_COLOUR = Color.OrangeRed;
            public static readonly Color MAIN_SQUARE_SELECTED_COLOUR = Color.Green;
            public static readonly Color SQUARE_NOT_SELECTED_COLOUR = Color.Orange;
            public static readonly Color SQUARE_NOT_SELECTABLE_COLOUR = Color.White;
            public static readonly Color SQUARE_COLOUR_0 = Color.Yellow;
            public static readonly Color SQUARE_COLOUR_1 = Color.Red;
            public static readonly Color SQUARE_IN_BLOCK_COLOUR = Color.Blue;
        }

       
    }
}
