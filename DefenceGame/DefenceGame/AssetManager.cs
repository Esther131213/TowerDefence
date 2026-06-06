using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceGame
{
    internal class AssetManager
    {
        //Towers
        public static Texture2D towerTex1;
        public static Texture2D towerTex2;
        public static Texture2D towerTex3;
        public static void LoadTextures(ContentManager content)
        {
            towerTex1 = content.Load<Texture2D>("2.png");
            towerTex2 = content.Load<Texture2D>("5.png");
            towerTex3 = content.Load<Texture2D>("7.png");
        }
    }
}
