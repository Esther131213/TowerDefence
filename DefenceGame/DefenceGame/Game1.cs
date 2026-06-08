using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Spline;
using System.Security.Cryptography.X509Certificates;

namespace DefenceGame
{
    public class Game1 : Game
    {
        public int TotalMoney = 0;
        new List<BasicEnemy> basiclist;
        public Rectangle EnemyHitbox;
        private BasicEnemy basicEnemy;
        private BasicTowerClass basicTowerClass;
        int position;
        int i;

        int BasicEnemyAmount = 1;

        Random rnd = new Random();
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            EnemyHitbox.Height = 30;
            EnemyHitbox.Width = 30;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            AssetManager.LoadTextures(Content);
            basiclist = new List<BasicEnemy>();
            CreateEnemy(1);
            // TODO: use this.Content to load your game content here
        }

        public void CreateEnemy(int position)
        {
            if (position == 1)
            {
                var enemy = new BasicEnemy(0.01f, 10, 10, new Vector2(0, 0), EnemyHitbox);
                basiclist.Add(enemy);
            }
            else if (position == 2)
            {

            }
        }

        //The Waves ---------------------------------------------------------------------
        public void Wave1()
        {


        }

        public void Wave2()
        {

        }

        //Update ------------------------------------------------------------------------
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (BasicEnemyAmount > 0)
            {
                CreateEnemy(1);
                BasicEnemyAmount--;
            }
            // TODO: Add your update logic here

            base.Update(gameTime);

            foreach (BasicEnemy enemy in basiclist)
            {
                enemy.Update(gameTime);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            //spriteBatch.Draw(AssetManager.towerTex1, new Vector2(0,0), Color.White);
            foreach(BasicEnemy enemy in basiclist)
            {
                basicEnemy.Draw(spriteBatch);
            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
