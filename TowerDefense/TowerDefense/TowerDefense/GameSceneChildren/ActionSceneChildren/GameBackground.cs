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
    public class GameBackground : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private Texture2D tex;
        Rectangle srcRec;

        public Texture2D Tex
        {
            get { return tex; }
            set { tex = value; }
        } 


        public GameBackground(Game game, SpriteBatch spriteBatch, Texture2D tex)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.tex = tex;
            Shared.origin = new Vector2(Shared.stage.X/2,Shared.stage.Y/2);
            srcRec = new Rectangle(0, 0, 900, 598);
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
            spriteBatch.Draw(tex, new Vector2(Shared.origin.X - srcRec.Width/2, Shared.origin.Y-srcRec.Height/2), 
                                srcRec, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
