using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewModdingAPI;

namespace DinosaurIslandMinigames.DinoRun
{
    public abstract class DinoState
    {
        protected DinoRunGame _game;
        protected IModHelper _helper;

        public DinoState(IModHelper helper, DinoRunGame dinoRun)
        {
            _helper = helper;
            _game = dinoRun;
        }

        public abstract void Draw(float gameTime, SpriteBatch spriteBatch);

        public abstract void Update(float gameTime);
    }
}