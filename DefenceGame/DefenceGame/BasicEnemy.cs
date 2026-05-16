using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceGame
{
    internal class BasicEnemy
    {
        int speed;
        int attackDmg;
        int health;
        public Vector2 position;
        public Rectangle hitbox;

        public BasicEnemy(int speed, int attackDmg, int health, Vector2 position, Rectangle hitbox)
        {
            this.speed = speed;
            this.attackDmg = attackDmg;
            this.health = health;
            this.position = position;
            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;

        }

        public void Update()
        {
            hitbox.X = (int)position.X;
            hitbox.Y = (int)position.Y;

            while (health > 0)
            {
                position.X += speed;
            }
        }

        public void EnemyDraw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(null, hitbox, Color.Red);
        }
    }
}
