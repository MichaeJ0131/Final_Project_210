
using System;

namespace cse210_batter_csharp.Casting
{
    public class Star : Actor
    {
        public Star()   
        
        {
           int x = Constants.MAX_X / 2;
           int y = Constants.MAX_Y / 2;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(0, 0)); 
           
           
           SetWidth(Constants.STAR_WIDTH);
           SetHeight(Constants.STAR_HEIGHT);
           SetImage(Constants.STAR_IMAGE);

        }
    }
}