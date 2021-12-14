using System;

namespace cse210_batter_csharp.Casting
{
    public class Planet : Actor
    {
       private string _description; 
        
        public Planet()
        {

           int x = Constants.MAX_X;
           int y = Constants.MAX_Y;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(14, 28));

           SetWidth(Constants.PLANET_WIDTH);
           SetHeight(Constants.PLANET_HEIGHT);
           SetImage(Constants.PLANET_IMAGE);
        }
        public string GetDescription()
        {
            return _description;

        }
        public void SetDescription(string description)
        {
            _description = description;
        }
    

    }
}