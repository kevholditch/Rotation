using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rotation.Drawing.ItemDrawers;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.StandardBoard.Rotation;
using Rotation.GameObjects.StandardBoard.Selection;
using Rotation.GameObjects.Tiles;

namespace Rotation.Game
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class RotationGame : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
	    private Board _board;
	    private IItemDrawerFactory _itemDrawerFactory;
	    private IEnumerable<IDrawableItem> _drawableItems;
	    private ISquareSelector _squareSelector;
	    private ISelectionRotatator _selectionRotatator;
	    private Point _currentPos;
	    private KeyboardState _oldKeyboardState;

		public RotationGame()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

		    _board = new BoardFactory().Create();
		    var boardFiller = new BoardFiller(new StandardTileFactory(new LetterLookup()));
            boardFiller.Fill(_board);

            var textureLoader = new TextureLoader(s => Content.Load<Texture2D>(s));
		    _itemDrawerFactory =
		        new ItemDrawerFactory(new List<IItemDrawer>
		                                  {
		                                      new SquareDrawer(
		                                          new TileTextureFactory(new List<ITileTextureCreator>
		                                                                     {
		                                                                         new BlankTileTextureCreator(textureLoader),
		                                                                         new StandardTileTextureCreator(textureLoader)
		                                                                     }),
                                                                             new SquareColourSelector())
		                                  });

		    _drawableItems = _board.GetDrawables();

            _currentPos = new Point(4, 4);
            _squareSelector = new SquareSelector();
            _squareSelector.Select(_board, _currentPos.X, _currentPos.Y);

            _selectionRotatator = new SelectionRotatator();

		    _oldKeyboardState = Keyboard.GetState();
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

	    
		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{

		    var currentKeyBoardState = Keyboard.GetState();

		    ReactToKeyPress(Keys.Up, _oldKeyboardState, currentKeyBoardState, () =>
		                                                                          {
		                                                                              _currentPos.X--;
		                                                                              _squareSelector.Select(_board,
		                                                                                                     _currentPos.X,
		                                                                                                     _currentPos.Y);
		                                                                          });

            ReactToKeyPress(Keys.Down, _oldKeyboardState, currentKeyBoardState, () =>
            {
                _currentPos.X++;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

            ReactToKeyPress(Keys.Left, _oldKeyboardState, currentKeyBoardState, () =>
            {
                _currentPos.Y--;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

            ReactToKeyPress(Keys.Right, _oldKeyboardState, currentKeyBoardState, () =>
            {
                _currentPos.Y++;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

		    ReactToKeyPress(Keys.S, _oldKeyboardState, currentKeyBoardState, () =>
		              _selectionRotatator.Right(_board));

            ReactToKeyPress(Keys.A, _oldKeyboardState, currentKeyBoardState, () =>
                      _selectionRotatator.Left(_board));

            ReactToKeyPress(Keys.Escape, _oldKeyboardState, currentKeyBoardState, () => Exit());

		    _oldKeyboardState = currentKeyBoardState;

		    


			base.Update(gameTime);
		}

        private void ReactToKeyPress(Keys key, KeyboardState oldKeyboardState, KeyboardState currentKeyboardState, Action actionToExcute)
        {
            if (currentKeyboardState.IsKeyDown(key))
            {
                if (!_oldKeyboardState.IsKeyDown(key))
                {
                    actionToExcute();
                }

            }
        }

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
		    foreach (var drawableItem in _drawableItems)
		    {
		        var itemDrawer = _itemDrawerFactory.Create(drawableItem);
                itemDrawer.Draw(spriteBatch, drawableItem);
		    }
            spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
