using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMonoGame
{
    internal class Entity
    {
        public Sprite sprite;
        private Texture2D texture;
        private Vector2 position;

        public Entity()
        {

        }

        public Entity(Sprite sprite)
        {
            this.sprite = sprite;
        }

        public Entity(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;

            sprite = new Sprite(texture, position);
        }

        public virtual void update(GameTime gameTime)
        {

        }
    }
}
