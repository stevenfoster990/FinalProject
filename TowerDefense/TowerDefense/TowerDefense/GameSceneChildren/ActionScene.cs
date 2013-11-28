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
    public class ActionScene : GameScene
    {
        private SpriteBatch spriteBatch;
        GameBackground gameBackground;
        Enemy enemy;

        public ActionScene(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            // TODO: Construct any child components here

            //Add game background
            this.spriteBatch = spriteBatch;
            gameBackground = new GameBackground(game, spriteBatch, 
                game.Content.Load<Texture2D>("images/HardMap")
                //game.Content.Load<Texture2D>("images/MediumMap")
                //game.Content.Load<Texture2D>("images/EasyMap")
                );
            this.Components.Add(gameBackground);

            //add enemy

            var pos = new Vector2(Shared.origin.X - 500, Shared.origin.Y - 50);
            enemy = new Enemy(game, spriteBatch, game.Content.Load<Texture2D>("images/Enemy"), pos);
            
            int delayCounter = 0;
            int delay = 200;
            int Ememies = 0;
            for (int i = 0; Ememies <= 10 ; i++)
            {
                delayCounter++;
                if (delayCounter > delay)
                {
                    delayCounter = 0;
                    Ememies++;
                    this.Components.Add(enemy);
                }
            }
           

            
            
           
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
    }
}
