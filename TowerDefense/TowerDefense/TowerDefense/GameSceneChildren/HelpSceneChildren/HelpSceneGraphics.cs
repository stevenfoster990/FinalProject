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
    public class HelpMenuGraphics : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private Texture2D tower;
        private Texture2D archer;
        private Texture2D darkKnight;
        Vector2 tPosition;
        Vector2 aPosition;
        Vector2 dPosition;

        public HelpMenuGraphics(Game game,
            SpriteBatch spriteBatch,
            Texture2D tower,
            Texture2D archer,
            Texture2D darkKnight)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.tower = tower;
            this.archer = archer;
            this.darkKnight = darkKnight;
            tPosition = new Vector2((Shared.stage.X/2 - 500 - tower.Width/2),
                Shared.stage.Y/2 - tower.Height/2);
            aPosition = new Vector2(tPosition.X + 380, tPosition.Y - 30);
            dPosition = new Vector2(Shared.stage.X - darkKnight.Width, Shared.stage.Y - darkKnight.Height/2);

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

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(tower, tPosition, Color.White);
            spriteBatch.Draw(archer, aPosition, Color.White);
            spriteBatch.Draw(darkKnight, dPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
