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
    public class Enemy : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private Texture2D tex;
        private Vector2 position;
        private float speed;

        public Texture2D Tex
        {
            get { return tex; }
            set { tex = value; }
        }
        


        public Enemy(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.tex = tex;
            this.position = position;
            this.speed = 1.0f; 
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

            position.X += speed;

            //if (position.X <= Shared.origin.X - 330)
            //{
            //    position.X += speed;
            //}
            //if (position.X <= Shared.origin.X-325 && position.X >= Shared.origin.X - 335)
            //{
            //    position.Y -= speed;
            //}
            //if (position.Y <= Shared.origin.Y - 180 && position.Y >= 190)
            //{
            //    position.X += speed;
            //}
            //if (position.X <= Shared.origin.X - 150 && position.X >= Shared.origin.X - 160)
            //{
            //    position.Y += speed;
            //}
            //if (position.Y <= Shared.origin.Y + 60 && position.Y >= Shared.origin.Y + 50)
            //{
            //    position.X += speed;
            //}
            //if (position.X <= Shared.origin.X + 100 && position.X >= Shared.origin.X + 90)
            //{
            //    position.Y -= speed;   
            //}
            //if (position.X > Shared.origin.X && position.Y <= Shared.origin.Y - 40 && position.Y >= Shared.origin.Y - 50)
            //{
            //    position.X += speed;
            //}
            


            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            spriteBatch.Begin();
            spriteBatch.Draw(tex, position, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
