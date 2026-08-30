using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewModdingAPI;

namespace DinosaurIslandMinigames.DinoRun
{
    public class DinoMainMenu : DinoState
    {
        private GameState? _newGame;
        
        public DinoMainMenu(IModHelper helper, DinoRunGame dinoRun) : base(helper, dinoRun)
        {
            
        }

        public override void Update(float gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Draw(float gameTime, SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}