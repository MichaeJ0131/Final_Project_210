using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;
using cse210_batter_csharp.Generators;




namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create the cast
        Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            cast["environment"] = new List<Actor>();
            
            
            // STARS STARS STARS STARS STARS STARS STARS STARS STARS STARS STARS STARS
            cast["stationary5"] = new List<Actor>();
            StarGenerator generator4 = new StarGenerator();
            for (int i = 0; i < Constants.NUM_STARS; i++)
            {
                Star star = generator4.Generate4();
                cast["stationary5"].Add(star);
            }


            
            // PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA PIZZA
            cast["stationary2"] = new List<Actor>();
            PizzaGenerator generator3 = new PizzaGenerator();
            for (int i = 0; i < Constants.NUM_PIZZAS; i++)
            {
                Pizza pizza = generator3.Generate3();
                cast["stationary2"].Add(pizza);
            }
            
            // SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP SHIP
            cast["stationary"] = new List<Actor>();
            // add progam movers
            cast["movers"] = new List<Actor>();
            Ship ship = new Ship();
            cast["movers"].Add(ship);
        
            // PLANET PLANET PLANET PLANET PLANET PLANET PLANET PLANET PLANET PLANET PLANET
            cast["stationary1"] = new List<Actor>();
            PlanetGenerator generator2 = new PlanetGenerator();
            for (int i = 0; i < Constants.NUM_PLANETS; i++)
            {
                Planet planet = generator2.Generate();
                cast["stationary1"].Add(planet);
            }
            
            // ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK ROCK 
            RockGenerator generator1 = new RockGenerator();
            for (int i = 0; i < Constants.NUM_ROCKS; i++)
            {
                Rock rock = generator1.Generate();
                cast["stationary"].Add(rock);
            }

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
         // AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);
            
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);
            AudioService audioService = new AudioService();

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Space Ranger 2000", Constants.FRAME_RATE);

            
        }
    }
}
