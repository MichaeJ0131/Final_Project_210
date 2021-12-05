using System;

namespace cse210_batter_csharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 3500;
        public const int MAX_Y = 2000;
        public const int FRAME_RATE = 25;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_ROCK = "./Assets/Rock.png";
        public const string IMAGE_SHIP = "./Assets/Ship.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        // public const int SHIP_X = MAX_X / 2;
        // public const int SHIP_Y = MAX_Y - 125;

        public const int SHIP_DX = 8;
        public const int SHIP_DY = SHIP_DX * -1;

        public const int ROCK_X = MAX_X / 2;
        public const int ROCK_Y = MAX_Y - 25;

        public const int ROCK_WIDTH = 28;
        public const int ROCK_HEIGHT = 24;

        public const int ROCK_SPACE = 5;
        public const int ROCK_SPEED = 25;
        public const int NUM_ROCKS = 12;

             
        // #endregion

        public const int SHIP_SPACE = 10;


        public const int SHIP_WIDTH = 350;
        public const int SHIP_HEIGHT = 190;
        public const int SHIP_SPEED = 25;


        // Display the billboard
        public const string DEFAULT_BILLBOARD_MESSAGE = "Space Ranger 2000";


        public const int TIMER_HEIGHT = 10;
        public const int TIMER_WIDTH = 1000;
        
    
    
    }

}