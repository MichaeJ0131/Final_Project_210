using System;

namespace cse210_batter_csharp.Casting
{
    public class Pizza : Actor
    {
       
       public Pizza()
       {
           int x = Constants.MAX_X;
           int y = Constants.MAX_Y;
           Point position = new Point(x, y);
           SetPosition(position);
           SetVelocity(new Point(0, 0));

           SetWidth(Constants.PIZZA_WIDTH);
           SetHeight(Constants.PIZZA_HEIGHT);
           SetImage(Constants.IMAGE_PIZZA);
       }
       public string GetDescription()
       {
           return _description;
       }
       private string _description; 
       public void SetDescription(string description)
       {
           _description = description;
       }
    

    }
}