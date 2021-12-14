using System;
using System.Collections.Generic;
using System.IO;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Generators
{
    public class StarGenerator : Generator

    {
        public Random _randomGenerator = new Random();
       
        public Star Generate4()
        {
            Star star = new Star();

            int x = _randomGenerator.Next(0, Constants.MAX_X);
            int y = _randomGenerator.Next(0, Constants.MAX_Y);
            star.SetPosition(new Point(x, y));

            return star;
        }
        
        // public string GetRandomMessage()
        // {
        //     string message = _messages[_randomGenerator.Next(0, _messages.Count)];
        //     return message;
        // }
        



    }            
}