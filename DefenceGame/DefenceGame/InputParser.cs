using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Spline;

namespace DefenceGame
{
    public static class InputParser
    {
        public static int parse_int(string str)
        {
            System.Diagnostics.Debug.WriteLine("parse_int " + str);
            int x;
            if (!int.TryParse(str, out x))
            {
                Console.WriteLine("Couldnt parse " + str + " to int. ");
            }
            System.Diagnostics.Debug.WriteLine("parse_int " + x.ToString());
            return x;
        }

        /*
        public static int[] parse_ints(string str)
        {
            string[] strings = str.Split(',');
            int[] ints = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {

            }

        }
        */
    }
}
