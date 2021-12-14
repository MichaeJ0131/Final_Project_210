using System;
using System.Collections.Generic;
using System.IO;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    public class PlanetGenerator : Generator

    {
        private Random _randomGenerator = new Random();
        public Planet Generate()
        {
            Planet planet = new Planet();

            int x = _randomGenerator.Next(0,2550);
            int y = _randomGenerator.Next(0 , 10);
            planet.SetPosition(new Point(x, y));

            return planet;
        }
        
        // public string GetRandomMessage()
        // {
        //     string message = _messages[_randomGenerator.Next(0, _messages.Count)];
        //     return message;
        // }


    }            
}