using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DinosaurIslandMinigames.DinoRun
{
    public class Sprite
    {
        public Vector2 position;
        public bool visible = true;
        public bool enabled = true;
        protected bool destroyed;
        public Sprite()
        {
            
        }

        public virtual void Update(float gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}