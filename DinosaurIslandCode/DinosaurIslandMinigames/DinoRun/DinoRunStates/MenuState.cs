using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewModdingAPI;

namespace DinosaurIslandMinigames
{
    public class MenuState : State
    {
        private GameState? _newGame;
        
        public MenuState(IModHelper helper, DinoRunGame dinoRun) : base(helper, dinoRun)
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