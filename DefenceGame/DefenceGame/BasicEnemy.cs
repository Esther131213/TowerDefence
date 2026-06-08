using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Spline;

namespace DefenceGame
{
    internal class BasicEnemy
    {
        float speed;
        int attackDmg;
        int health;
        public Vector2 position;
        public Rectangle hitbox;

        public BasicEnemy(float speed, int attackDmg, int health, Vector2 position, Rectangle hitbox)
        {
            this.speed = speed;
            this.attackDmg = attackDmg;
            this.health = health;
            this.position = position;
            this.hitbox.Width = hitbox.Width;
            this.hitbox.Height = hitbox.Height;
        }

        public void Update(GameTime gameitme)
        {
            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;

            while (health > 0)
            {
                position.X += speed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.towerTex1, hitbox, Color.Red);
        }
    }
}