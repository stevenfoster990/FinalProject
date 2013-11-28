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
    public class StartScene : GameScene
    {
        private MenuComponent menuComponent;

        public MenuComponent MenuComponent
        {
            get { return menuComponent; }
            set { menuComponent = value; }
        }
        private SpriteBatch spriteBatch;
        private string[] menu = {"Start Game",
                                    "Help",
                                    "High Score",
                                    "Credit",
                                    "Quit"};

        public StartScene(Game game,
            SpriteBatch spriteBatch)
            : base(game)
        {
            // TODO: Construct any child components here

            var mBackground = new MenuBackground(game, spriteBatch,

                //toggle between possible menu backgound choices

            //    game.Content.Load<Texture2D>("images/MenuBackground")
                game.Content.Load<Texture2D>("images/MenuBackground2")
            );
            this.Components.Add(mBackground);

            this.spriteBatch = spriteBatch;
            menuComponent = new MenuComponent(game,
                spriteBatch,
                game.Content.Load<SpriteFont>("fonts/RegularFont"),
                game.Content.Load<SpriteFont>("fonts/HilightFont"),
                menu, new Vector2(200, 100));
            this.Components.Add(menuComponent);
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
