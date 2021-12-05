using System;

namespace cse210_batter_csharp.Casting
{
    public class Rock : Actor
    {
        public Rock()

        {


           int x = Constants.MAX_X;
           int y = Constants.MAX_Y;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(30, 0));

           SetWidth(Constants.ROCK_WIDTH);
           SetHeight(Constants.ROCK_HEIGHT);
           SetImage(Constants.IMAGE_ROCK); // after new image change ball image to a ship image

        }
    }
}