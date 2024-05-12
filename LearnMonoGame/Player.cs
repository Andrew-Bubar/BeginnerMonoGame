using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMonoGame
{
    internal class Player : Sprite
    {

        public Player(Texture2D texture, Vector2 position) : base(texture, position)
        {
            this.color = Color.Black;
        }

        public override void update(GameTime gt)
        {
            base.update(gt);

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += 1f;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= 1f;
            }
        }
    }
}
