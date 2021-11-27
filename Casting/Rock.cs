using System;

namespace cse210_batter_csharp.Casting
{
    public class Rock : Actor
    {
        public Rock(Point _position)

        {
           SetPosition(_position); 
           SetWidth(Constants.ROCK_WIDTH);
           SetHeight(Constants.ROCK_HEIGHT);
           SetImage(Constants.IMAGE_ROCK); // after new image change ball image to a ship image

        }
    }
}