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
        public const int DEFAULT_SQUARE_SIZE = 200;
        public const int DEFAULT_FONT_SIZE = 200;
        
        public const int DEFAULT_TEXT_OFFSET = 50;

        // SOUND SOUND SOUND SOUND
        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        // ROCK ROCK ROCK ROCK ROCK ROCK   
        public const string IMAGE_ROCK = "./Assets/Rock.png"; 
        public const int ROCK_X = MAX_X - 3400;
        public const int ROCK_Y = MAX_Y - 25;
        public const int ROCK_WIDTH = 190;
        public const int ROCK_HEIGHT = 100;
        public const int ROCK_SPACE = 25;
        public const int ROCK_SPEED = 1;
        public const int NUM_ROCKS = 14;
        public const int DEFAULT_ROCK_OFFSET = 50;

        // SHIP SHIP SHIP SHIP SHIP
        public const string IMAGE_SHIP = "./Assets/Ship.png";
        public const int SHIP_SPACE = 10;
        public const int SHIP_WIDTH = 350;
        public const int SHIP_HEIGHT = 170;
        // 190
        public const int SHIP_SPEED = 25;
        public const int SHIP_DX = 8;
        public const int SHIP_DY = SHIP_DX * -1;

        // TIMER TIMER TIMER    
        public const int TIMER_HEIGHT = 10;
        public const int TIMER_WIDTH = 1000;
        
        // PIZZA PIZZA PIZZA PIZZA PIZZA
        public const string IMAGE_PIZZA = "./Assets/pizza.png"; 
        public const int PIZZA_X = MAX_X - 3400;
        public const int PIZZA_Y = MAX_Y - 25;
        public const int PIZZA_HEIGHT = 190;
        public const int PIZZA_WIDTH = 190;
        public const int PIZZA_SPEED = 10;
        public const int NUM_PIZZAS  = 1;
        public const int DEFAULT_PIZZA_OFFSET = 400;
        public const int DEFAULT_PIZZA_SIZE = 600;

        // BILLBOARD BILLBOARD BILLBOARD    
        public const string DEFAULT_BILLBOARD_MESSAGE = "Space Ranger 2000";
    
        // MMMMMMMMMMMMMMMMMMMM
        public const string MESSAGE_FILE = "messages.txt";


        public const int PLANET_WIDTH = 190;
        public const int PLANET_HEIGHT = 190;
        public const string PLANET_IMAGE = "./Assets/Planet.png";
        
        public const int DEFAULT_PLANET_SIZE = 60;

        public const int NUM_PLANETS = 3;

        // STAR STAR STAR STAR STAR

        public const int NUM_STARS = 800;

        public const int DEFAULT_STAR_SIZE = 10;

        public const int STAR_HEIGHT =10;
        public const int STAR_WIDTH = 10;

        // public const int STAR
        public const string STAR_IMAGE = "./Assets/Star.png";

        public const string GOOD = "./Assets/Good.wav";
        public const string PLANETC = "./Assets/Planetc.wav";



        


    }

}