using System;

namespace cse210_batter_csharp.Casting
{
    class Paddle : Actor
    {
        public Paddle(Point _position)

        {
           SetPosition(_position); 
           SetWidth(Constants.PADDLE_WIDTH);
           SetHeight(Constants.PADDLE_HEIGHT);
           SetImage(Constants.IMAGE_PADDLE);

        }
    }
}