using System;
using System.Collections.Generic;
using System.IO;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    public class RockGenerator

    {
    
        private Random _randomGenerator = new Random();
            
        public Rock Generate()
        {
            Rock rock = new Rock();

            int x = _randomGenerator.Next(0, Constants.MAX_X - Constants.DEFAULT_FONT_SIZE);
            int y = _randomGenerator.Next(0, Constants.MAX_Y - Constants.DEFAULT_FONT_SIZE);
            rock.SetPosition(new Point(x, y));

            return rock;
        }
    }            
}