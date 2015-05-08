using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    public class Player
    {
        // Animation representing the player
        private Texture2D playerTexture;

        public Vector2 Position;

        // State of the player
        private bool active;

        // Amount of hit points that player has
        private int health;

      

        public Texture2D PlayerTexture
        {
            get { return playerTexture; }
        }

        // Get the width of the player ship
        public int Width
        {
            get { return playerTexture.Width; }
        }

        // Get the height of the player ship
        public int Height
        {
            get { return playerTexture.Height; }
        }



        public bool Active
        {
            get { return active; }
            set { active = value; }

        }

        public int Health
        {
            get { return health; }
            set { health = value; }

        }




        public void Initialize(Texture2D texture, Vector2 position)
        {

            playerTexture = texture;

            // Set the starting position of the player around the middle of the screen and to the back
            Position = position;

            // Set the player to be active
            Active = true;

            // Set the player health
            Health = 100;


        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            
        }
    }
}