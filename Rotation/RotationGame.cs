using Autofac;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Controls;
using Rotation.Drawing.Animations;
using Rotation.Engine;
using Rotation.Events;
using Rotation.StandardBoard;
using Rotation.Textures;


namespace MonoRotation
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class RotationGame : Game, ITextureLoader
    {
        private GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IBoard _board;
        private IDrawEngine _drawEngine;
        private readonly IContainer _container;
        private IBoardFiller _boardFiller;
        private readonly IAnimationEngine _animationEngine;
        private IGameStateController _gameStateController;

        public RotationGame(IContainer container, IBoard board, IBoardFiller boardFiller, IGameEventDispatcher gameEventDispatcher, IAnimationEngine animationEngine, IGameStateController gameStateController)
        {
            _container = container;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _board = board;
            _boardFiller = boardFiller;
            _animationEngine = animationEngine;
            _gameStateController = gameStateController;
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
            CurrentGraphicsDevice = GraphicsDevice;

            _boardFiller.Fill(_board);
            _drawEngine = _container.Resolve<IDrawEngine>();

            _gameStateController.Initialise();

        }

        public static GraphicsDevice CurrentGraphicsDevice { get; private set; }

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
            _gameStateController.Update(gameTime);
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            _animationEngine.Run(gameTime);
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
