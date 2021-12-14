using System;

namespace cse210_batter_csharp.Casting
{
    public class Rock : Actor
    {
        public Rock()

        {

           int x = 2500;
           int y = Constants.MAX_Y;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(24, 0));
        //    25

           SetWidth(Constants.ROCK_WIDTH);
           SetHeight(Constants.ROCK_HEIGHT);
           SetImage(Constants.IMAGE_ROCK);

        }
    }
}