using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Rotation.Drawing
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
        }

        public static class RotationAnimation
        {
            public const int ANGLE_INCREASE_RATE = 6;
        }
    }
}
