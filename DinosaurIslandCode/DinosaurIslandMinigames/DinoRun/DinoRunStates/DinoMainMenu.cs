using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewValley.Menus;
using StardewModdingAPI;
using System.Numerics;
using System.Drawing;

namespace DinosaurIslandMinigames.DinoRun
{
    public class DinoMainMenu : DinoState
    {
        private DinoGame? _newGame;
        
        public DinoMainMenu(IModHelper helper, DinoRunGame dinoRun) : base(helper, dinoRun)
        {
            
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