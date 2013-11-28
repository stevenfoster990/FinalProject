

// Main game class (game1.cs)

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
    /// This is the main type for your game
    /// </summary>
    public class TowerDefenseGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        GameScene startScene;
        GameScene actionScene;
        GameScene helpScene;
        //declare other scenes here
        //GameScene aboutScene;
        //GameScene HiscoreScene;

        public TowerDefenseGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            this.graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            this.graphics.IsFullScreen = true;
            Shared.stage = new Vector2(graphics.PreferredBackBufferWidth,
                graphics.PreferredBackBufferHeight);
            Shared.origin = new Vector2(graphics.PreferredBackBufferWidth / 2,
                graphics.PreferredBackBufferHeight / 2);
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

            // TODO: use this.Content to load your game content here
            // remove this block later
            //StartScene startScene = new StartScene(this, spriteBatch);
            //this.Components.Add(startScene);
            //startScene.show();
            // remove this block

            helpScene = new HelpScene(this, spriteBatch);
            this.Components.Add(helpScene);

            actionScene = new ActionScene(this, spriteBatch);
            this.Components.Add(actionScene);

            //instantiate other scenes here;

            startScene = new StartScene(this, spriteBatch);
            this.Components.Add(startScene);
            startScene.show();


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        private void hideAllScenes()
        {
            foreach (GameScene item in Components)
            {
                item.hide();
            }
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            KeyboardState ks = Keyboard.GetState();
            MouseState ms = Mouse.GetState();

            int selectedIndex = 0;

            // START MENU CONTROLES
            if (startScene.Enabled)
            {
                selectedIndex = ((StartScene)startScene).MenuComponent.SelectedIndex;

                //KEYBOARD CONTROLES
                if (ks.IsKeyDown(Keys.Enter) && selectedIndex == 0)
                {
                    hideAllScenes();
                    actionScene.show();
                }

                if (ks.IsKeyDown(Keys.Enter) && selectedIndex == 1)
                {
                    hideAllScenes();
                    helpScene.show();
                }

                // do the same for the other scenes;

                if (ks.IsKeyDown(Keys.Enter) && selectedIndex == 4)
                {
                    this.Exit();
                }

                //MOUSE CONTROLES
                if (ms.LeftButton == ButtonState.Pressed && selectedIndex == 0)
                {
                    hideAllScenes();
                    actionScene.show();
                }
                if (ms.LeftButton == ButtonState.Pressed && selectedIndex == 1)
                {
                    hideAllScenes();
                    helpScene.show();
                }
                if (ms.LeftButton == ButtonState.Pressed && selectedIndex == 4)
                {
                    this.Exit();
                }
            }

            //HELP SCENE CONTROLES
            if (helpScene.Enabled)
            {
                //KEYBOARD CONTROLES
                if (ks.IsKeyDown(Keys.Escape))
                {
                    hideAllScenes();
                    startScene.show();
                }

                //MOUSE CONTROLES

                if (ms.RightButton == ButtonState.Pressed)
                {
                    hideAllScenes();
                    startScene.show();
                }
            }

            // ACTION SCENE CONTROLES
            if (actionScene.Enabled)
            {
                //KEYBOARD CONTROLES
                if (ks.IsKeyDown(Keys.Escape))
                {
                    hideAllScenes();
                    startScene.show();
                }
                //MOUSE CONTROLES

            }

           


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
