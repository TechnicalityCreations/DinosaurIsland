using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewModdingAPI;

namespace DinosaurIslandMinigames
{
    public abstract class State
    {
        protected DinoRunGame _game;
        protected IModHelper _helper;

        public State(IModHelper helper, DinoRunGame dinoRun)
        {
            _helper = helper;
            _game = dinoRun;
        }

        public abstract void Draw(float gameTime, SpriteBatch spriteBatch);

        public abstract void Update(float gameTime);
    }
}