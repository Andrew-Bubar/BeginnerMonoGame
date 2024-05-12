using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace LearnMonoGame
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 position;
        private static readonly float scale = 5f;
        public Color color = Color.White;

        private Rectangle rect
        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y,
                    texture.Width *(int)scale,
                    texture.Height* (int)scale
                    );
            }
        }

        //Constructors
        public Sprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public virtual void update(GameTime gt)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, color);
        }
    }
}
