using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewModdingAPI;

namespace DinosaurIslandMinigames.DinoRun
{
    public class DinoGame : DinoState
    {
        private GameBackground background;
        
        public DinoGame(IModHelper helper, DinoRunGame dinoRun, DinoLevel dinoLevel) : base(helper, dinoRun)
        {
            background = new GameBackground(dinoLevel);
        }

        public override void Update(float gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}