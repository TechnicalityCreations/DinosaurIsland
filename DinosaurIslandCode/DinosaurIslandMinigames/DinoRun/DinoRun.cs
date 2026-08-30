using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley;
using StardewValley.Minigames;

namespace DinosaurIslandMinigames.DinoRun
{
    public class DinoRunGame : IMinigame
    {
        public DinoRunGame()
        {
            
        }

        public void changeScreenSize()
        {
            // TODO: Change screen size to appropriate size for dino game.
            // One idea: use same screen size as junimo cart
        }

        public bool doMainGameUpdates()
        {
            return false;
        }

        public string minigameId()
        {
            return "DinoRun";
        }

        public bool overrideFreeMouseMovement()
        {
            return Game1.options.SnappyMenus;
        }

        public void receiveLeftClick(int x, int y, bool playSound = true)
        {
            // Required for IMinigame. Leave empty.
        }

        public void releaseLeftClick(int x, int y)
        {
            // Required for IMinigame. Leave empty.
        }

        public void leftClickHeld(int x, int y)
        {
            // Required for IMinigame. Leave empty.
        }

        public void receiveRightClick(int x, int y, bool playSound = true)
        {
            // Required for IMinigame. Leave empty.
        }

        public void releaseRightClick(int x, int y)
        {
            // Required for IMinigame. Leave empty.
        }

        public void receiveKeyPress(Keys k)
        {
            // TODO: Implement key presses
            // Space (A on gamepad): Jump
            // Escape (Back on gamepad): Quit minigame
            // P to pause (Stardew implements gamepad controls using options?)
        }

        public void receiveKeyRelease(Keys k)
        {
            // Required for IMinigame. Likely will not use.
        }

        public void receiveEventPoke(int data)
        {
            throw new NotImplementedException();
        }

        public bool tick(GameTime gameTime)
        {
            // TODO: Implement tick as minigames do not run on GameTime
            // Returns false if game is ongoing
            // Returns true if game is finished
            // Personal Note: Seems redunant to code any path to true if unload is a method. JunimoCart seems to never return true from this method.
            return true;
        }

        public bool forceQuit()
        {
            // TODO: Force unload
            // Save high score before unloading
            return true;
        }

        public void unload()
        {
            // TODO: Close minigame
        }

        public void Update(float time)
        {
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}