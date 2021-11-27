
using System;

namespace cse210_batter_csharp.Casting
{
    class Brick : Actor
    {
        public Brick(Point _position)

        {
           SetPosition(_position); 
           SetWidth(Constants.BRICK_WIDTH);
           SetHeight(Constants.BRICK_HEIGHT);
           SetImage(Constants.IMAGE_BRICK);

        }
    }
}