
using System;

namespace cse210_batter_csharp.Casting
{
    class Ship : Actor
    {
        public Ship()   
        
        {
   
           int x = Constants.MAX_X / 2;
           int y = Constants.MAX_Y / 2;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(2, 0)); 
           
           
           SetWidth(Constants.SHIP_WIDTH);
           SetHeight(Constants.SHIP_HEIGHT);
           SetImage(Constants.IMAGE_SHIP);

        }
    }
}

