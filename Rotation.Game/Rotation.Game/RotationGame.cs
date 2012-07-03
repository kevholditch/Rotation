using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rotation.Drawing;
using Rotation.Drawing.Configuration;
using Rotation.Drawing.ItemDrawers;
using Rotation.Drawing.ItemDrawers.Squares;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.Configuration;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Drawing.ItemAnimators;
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
	    private ISquareSelector _squareSelector;
	    private ISelectionRotatator _selectionRotatator;
	    private Point _currentPos;
	    private KeyboardState _oldKeyboardState;
	    private IAnimationEngine _animationEngine;

	    private IContainer _container;

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
		    var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new InterfaceConventionModule(new[]{ typeof(IItemDrawer).Assembly, typeof(IItemAnimator).Assembly}));
            containerBuilder.RegisterModule(new TypeModule());
            containerBuilder.RegisterModule(new DrawingModule());

		    containerBuilder.RegisterInstance(new XnaTextureLoader(s => Content.Load<Texture2D>(s))).As<ITextureLoader>();
		    containerBuilder.RegisterInstance(new BoardFactory().Create()).As<Board>().As<IGetMainSelectedSquare>().As
		        <IGetAnimatableItems>().SingleInstance();
		    _container = containerBuilder.Build();

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
		    _board = _container.Resolve<Board>();

		    var boardFiller = _container.Resolve<IBoardFiller>();
            boardFiller.Fill(_board);

		    _animationEngine = _container.Resolve<IAnimationEngine>();
           

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

		    ReactToKeyPress(Keys.Up, currentKeyBoardState, () =>
		    {
		        _currentPos.Y--;
		        _squareSelector.Select(_board,
		                                _currentPos.X,
		                                _currentPos.Y);
		    });

            ReactToKeyPress(Keys.Down, currentKeyBoardState, () =>
            {
                _currentPos.Y++;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

            ReactToKeyPress(Keys.Left, currentKeyBoardState, () =>
            {
                _currentPos.X--;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

            ReactToKeyPress(Keys.Right, currentKeyBoardState, () =>
            {
                _currentPos.X++;
                _squareSelector.Select(_board,
                                       _currentPos.X,
                                       _currentPos.Y);
            });

		    ReactToKeyPress(Keys.S, currentKeyBoardState, () =>
		              _selectionRotatator.Right(_board));

            ReactToKeyPress(Keys.A, currentKeyBoardState, () =>
                      _selectionRotatator.Left(_board));

            
            ReactToKeyPress(Keys.Escape, currentKeyBoardState, Exit);

		    _oldKeyboardState = currentKeyBoardState;


			base.Update(gameTime);
		}

        private void ReactToKeyPress(Keys key, KeyboardState currentKeyboardState, Action actionToExcute)
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
		    _animationEngine.Animate(spriteBatch);
            spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
