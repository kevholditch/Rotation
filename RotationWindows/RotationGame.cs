
using System;
using Autofac;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rotation.Drawing.Animations;
using Rotation.Engine;
using Rotation.Events;
using Rotation.StandardBoard;
using Rotation.StandardBoard.Rotation;
using Rotation.StandardBoard.Selection;
using Rotation.Textures;
using Rotation.Words;


namespace MonoRotation
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class RotationGame : Game, ITextureLoader
    {

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IBoard _board;
        private ISquareSelector _squareSelector;
        private ISelectionRotatator _selectionRotatator;
        private Point _currentPos;
        private KeyboardState _oldKeyboardState;
        private IDrawEngine _drawEngine;
        private readonly IContainer _container;
        private IBoardFiller _boardFiller;
        private readonly IAnimationEngine _animationEngine;
        private IWordChecker _wordChecker;

        public RotationGame(IContainer container, IBoard board, IBoardFiller boardFiller, ISelectionRotatator selectionRotatator, ISquareSelector squareSelector, IGameEventDispatcher gameEventDispatcher, IAnimationEngine animationEngine, IWordChecker wordChecker)
        {
            _container = container;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _board = board;
            _boardFiller = boardFiller;
            _selectionRotatator = selectionRotatator;
            _squareSelector = squareSelector;
            _animationEngine = animationEngine;
            _wordChecker = wordChecker;
            GameEvents.Dispatcher = gameEventDispatcher;
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
         

            spriteBatch = new SpriteBatch(GraphicsDevice);

            _boardFiller.Fill(_board);
            _drawEngine = _container.Resolve<IDrawEngine>();

            _currentPos = new Point(4, 4);
            _squareSelector.Select(_board, _currentPos.X, _currentPos.Y);

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

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            _animationEngine.Run();
            _drawEngine.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public Texture2D Load(string assetName)
        {
            return Content.Load<Texture2D>(assetName);
        }
    }
}
