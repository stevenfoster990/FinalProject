using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace TowerDefense
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class HelpScene : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D tex;
        internal Rectangle srcRec = new Rectangle(0, 0, 712, 500);
        HelpMenuGraphics menuGraphics;
        Vector2 recPos;

        MouseState oldMouseState;

        public HelpScene(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            recPos = new Vector2(Shared.origin.X - srcRec.Width / 2, Shared.origin.Y - srcRec.Height / 2);
            tex = game.Content.Load<Texture2D>("images/Larum ipsum");
            menuGraphics = new HelpMenuGraphics(game, spriteBatch,
                game.Content.Load<Texture2D>("images/HelpMenuTower"),
                game.Content.Load<Texture2D>("images/archer"),
                game.Content.Load<Texture2D>("images/darkKnight"));
            this.Components.Add(menuGraphics);
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            MouseState ms = Mouse.GetState();

            // Controles the scroll of the help page in the rectangle
            if (ms.ScrollWheelValue > oldMouseState.ScrollWheelValue)
            {
                srcRec.Y = srcRec.Y + 10;
            }

            if (ms.ScrollWheelValue < oldMouseState.ScrollWheelValue)
            {
                srcRec.Y = srcRec.Y - 10;
            }

            oldMouseState = ms;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(tex, recPos, srcRec, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
