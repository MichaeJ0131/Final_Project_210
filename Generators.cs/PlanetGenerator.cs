using System;
using System.Collections.Generic;
using System.IO;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    public class PlanetGenerator : Generator

    {
        private Random _randomGenerator = new Random();
        private List<string> _messages;

        public PlanetGenerator()
        {
            LoadMessages();
        }

        private void LoadMessages()
        {
            string[] allLines = File.ReadAllLines(Constants.MESSAGE_FILE);

            _messages = new List<string>();
            foreach (string line in allLines)
            {
                _messages.Add(line);

            }
        }
        public Planet Generate()
        {
            Planet planet = new Planet();

            int x = _randomGenerator.Next(0,1500);
            int y = _randomGenerator.Next(0 , 100);
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