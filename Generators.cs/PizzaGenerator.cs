using System;
using System.Collections.Generic;
using System.IO;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Casting
{
    public class PizzaGenerator : Generator

    {
        private Random _randomGenerator = new Random();
        public Pizza Generate3()
        {
            Pizza pizza = new Pizza();

            int x = _randomGenerator.Next(500,800);
            int y = _randomGenerator.Next(400,1800);
            pizza.SetPosition(new Point(x, y));

            return pizza;
        }
    
    }            
}