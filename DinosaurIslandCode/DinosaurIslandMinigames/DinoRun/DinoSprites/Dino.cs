namespace DinosaurIslandMinigames.DinoRun
{
    public class Dino : Sprite
    {
        public bool canMove { get; set; }
        private bool isJumping;
        public Dino()
        {
            
        }

        public bool Death()
        {
            // TODO: Display death animation
            // Return true once animation is complete
            return true;
        }

        public bool IsJumping()
        {
            return isJumping;
        }

        public void Jump()
        {
            if (!isJumping && canMove)
            {
                // TODO: Enter code to perform jump
                isJumping = true;
            }
        }
    }
}