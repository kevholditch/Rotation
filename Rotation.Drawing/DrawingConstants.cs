﻿using System;
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
        }

        public static class SquareColours
        {
            public static readonly Color SQUARE_SELECTED_COLOUR = Color.OrangeRed;
            public static readonly Color MAIN_SQUARE_SELECTED_COLOUR = Color.Red;
            public static readonly Color SQUARE_NOT_SELECTED_COLOUR = Color.Orange;
            public static readonly Color SQUARE_NOT_SELECTABLE_COLOUR = Color.White;
        }
    }
}