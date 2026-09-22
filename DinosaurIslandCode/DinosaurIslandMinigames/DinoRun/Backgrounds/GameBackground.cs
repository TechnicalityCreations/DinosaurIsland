using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DinosaurIslandMinigames.DinoRun
{
    public class GameBackground
    {
        private Texture2D baseBackground;
        private List<BackgroundSprite> backgroundSprites;
        private DinoLevel level;
        
        /// <summary>
        /// Handles the DinoRun minigame background
        /// </summary>
        /// <param name="startLevel">Starting level for the background</param>
        public GameBackground(DinoLevel startLevel)
        {
            level = startLevel;
        }

        public void ChangeLevel(DinoLevel newLevel)
        {
            // TODO: Dino should go into appropriate transition (cave, vines, trees, etc.)
            // TODO: Replaces background once transition is complete
            level = newLevel;
        }

        public void Update(float gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}