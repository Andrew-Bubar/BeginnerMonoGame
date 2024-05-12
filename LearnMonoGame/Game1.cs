using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LearnMonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //ball varribles
        List<Sprite> entities;

        Vector2 playerPos;
        Vector2 badPos;
        float ballSpeed;
        Player player;
        Sprite badBall;

        // input vars
        bool space_pressed = false;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        // runs when program starts
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            playerPos = new Vector2(0, 10);
            badPos = new Vector2(0, 300);
            ballSpeed = 0.5f;

            base.Initialize();
        }

        // for art
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            entities = new();

            // TODO: use this.Content to load your game content here
            Texture2D ballTex = this.Content.Load <Texture2D> ("ball") ;

            entities.Add(new Sprite(ballTex, new Vector2(100, 100)));
            entities.Add(new Sprite(ballTex, new Vector2(100, 300)));
            entities.Add(new Sprite(ballTex, new Vector2(400, 100)));
            entities.Add(new Player(ballTex, new Vector2(10, 10)));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            
            //updating sprites
            foreach(var ball in entities) { ball.update(gameTime); }
            // TODO: Add your update logic here
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //setting up the area to select content to draw
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            
            foreach(var sprite in entities) { sprite.Draw(_spriteBatch); }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
