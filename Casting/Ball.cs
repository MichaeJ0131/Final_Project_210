using System;

namespace cse210_batter_csharp.Casting
{
    class Ball : Actor
    {
        public Ball(Point _position)

        {
           SetPosition(_position); 
           SetWidth(Constants.BALL_WIDTH);
           SetHeight(Constants.BALL_HEIGHT);
           SetImage(Constants.IMAGE_BALL);

        }
    }
}